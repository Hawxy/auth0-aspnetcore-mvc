﻿using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.IO;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace Auth0.AspNetCore.Mvc.IntegrationTests
{
    /// <summary>
    /// Utils class to generate a JWT token for testing purposes.
    /// </summary>
    internal static class JwtUtils
    {
        /// <summary>
        /// Generate a JWT token using the provided options
        /// </summary>
        /// <param name="userId">The user's ID, used as Name and sub claim.</param>
        /// <param name="issuer">The token's Issuer.</param>
        /// <param name="audience">The token's Audience</param>
        /// <param name="org_id">The (optional) org_id claim to be used.</param>
        /// <param name="nonce">The (optional) nonce to be used.</param>
        /// <returns>The generated JWT token.</returns>
        public static string GenerateToken(int userId, string issuer, string audience, string org_id = null, string nonce = null, DateTime? expires = null)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, userId.ToString()),
                new Claim(JwtRegisteredClaimNames.Sub, userId.ToString()),
            };

            if (!string.IsNullOrWhiteSpace(org_id))
            {
                claims.Add(new Claim("org_id", org_id));
            }

            if (!string.IsNullOrWhiteSpace(nonce))
            {
                claims.Add(new Claim(JwtRegisteredClaimNames.Nonce, nonce));
            }

            JsonWebKeySet keys = new JsonWebKeySet(GetKeys().Result);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = expires != null ? expires : DateTime.UtcNow.AddDays(7),
                Issuer = issuer,
                Audience = audience,
                SigningCredentials = new SigningCredentials(keys.Keys[0], SecurityAlgorithms.RsaSha256)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }

        private static async Task<string> GetKeys()
        {
            var resourceName = "Auth0.AspNetCore.Mvc.IntegrationTests.jwks.json";
            using (var stream = typeof(Startup).Assembly.GetManifestResourceStream(resourceName))
            using (var reader = new StreamReader(stream))
            {
                var body = await reader.ReadToEndAsync();
                return body;
            }
        }
    }
}
