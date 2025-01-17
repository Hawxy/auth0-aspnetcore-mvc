﻿namespace Auth0.AspNetCore.Mvc
{
    public static class Auth0AuthenticationParameters
    {
        internal static readonly string Prefix = "Auth0";

        /// <summary>
        /// The key used for the scope entry in AuthenticationProperties.Items
        /// </summary>
        public static readonly string Scope = $"{Prefix}:scope";

        /// <summary>
        /// The key used for the audience entry in AuthenticationProperties.Items
        /// </summary>
        public static readonly string Audience = $"{Prefix}:audience";

        /// <summary>
        /// The key used for the organization entry in AuthenticationProperties.Items
        /// </summary>
        public static readonly string Organization = $"{Prefix}:organization";

        /// <summary>
        /// The key used for the invitation entry in AuthenticationProperties.Items
        /// </summary>
        public static readonly string Invitation = $"{Prefix}:invitation";

        /// <summary>
        /// Generate a key for any extra parameter entry in AuthenticationProperties.Items
        /// </summary>
        /// <returns>The key used for the extra parameter entry in AuthenticationProperties.Items</returns>
        public static string Parameter(string key)
        {
            return $"{Prefix}:{key}";
        }
    }
}
