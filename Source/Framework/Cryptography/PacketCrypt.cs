﻿/*
 * Copyright (C) 2012-2019 CypherCore <http://github.com/CypherCore>
 * 
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */

using Security.Cryptography;
using System;
using System.Security.Cryptography;

namespace Framework.Cryptography
{
    public sealed class WorldCrypt : IDisposable
    {
        static readonly byte[] ServerEncryptionKey = { 0x08, 0xF1, 0x95, 0x9F, 0x47, 0xE5, 0xD2, 0xDB, 0xA1, 0x3D, 0x77, 0x8F, 0x3F, 0x3E, 0xE7, 0x00 };
        static readonly byte[] ServerDecryptionKey = { 0x40, 0xAA, 0xD3, 0x92, 0x26, 0x71, 0x43, 0x47, 0x3A, 0x31, 0x08, 0xA6, 0xE7, 0xDC, 0x98, 0x2A };

        public void Initialize(byte[] key)
        {
            if (IsInitialized)
                throw new InvalidOperationException("PacketCrypt already initialized!");

            _clientDecrypt = new AuthenticatedAesCng();
            _clientDecrypt.Key = key;
            _clientDecrypt.CngMode = CngChainingMode.Gcm;
            _clientDecrypt.TagSize = 96;

            _serverEncrypt = new AuthenticatedAesCng();
            _serverEncrypt.Key = key;
            _serverEncrypt.CngMode = CngChainingMode.Gcm;
            _serverEncrypt.TagSize = 96;

            IsInitialized = true;
        }

        public bool Encrypt(ref byte[] data, int length, ref byte[] tag)
        {
            if (IsInitialized)
            {
                _serverEncrypt.IV = BitConverter.GetBytes(_serverCounter).Combine(BitConverter.GetBytes(0x52565253));

                using (IAuthenticatedCryptoTransform encryptor = _serverEncrypt.CreateAuthenticatedEncryptor())
                {
                    data = encryptor.TransformFinalBlock(data, 0, length);
                    tag = encryptor.GetTag();
                }
            }

            ++_serverCounter;
            return true;
        }

        public bool Decrypt(ref byte[] data, int length, byte[] tag)
        {
            if (IsInitialized)
            {
                _clientDecrypt.IV = BitConverter.GetBytes(_clientCounter).Combine(BitConverter.GetBytes(0x544E4C43));
                _clientDecrypt.Tag = tag;

                using (ICryptoTransform decryptor = _clientDecrypt.CreateDecryptor())
                    data = decryptor.TransformFinalBlock(data, 0, length);
            }

            ++_clientCounter;
            return true;
        }

        public void Dispose()
        {
            IsInitialized = false;
        }

        public bool IsInitialized { get; set; }

        AuthenticatedAesCng _clientDecrypt;
        AuthenticatedAesCng _serverEncrypt;
        ulong _clientCounter;
        ulong _serverCounter;
    }

}
