﻿using System.Security.Claims;

namespace DrKlinik.Server.Data
{
    public class JwtReader
    {
        public static int GetUserId(ClaimsPrincipal user)
        {
            var identity = user.Identity as ClaimsIdentity;

            if (identity is null)
            {
                return 0;

            }
            var claim = identity.Claims.FirstOrDefault(c => c.Type.ToLower() == "id");

            if (claim is null)
            {
                return 0;
            }

            int id;

            try
            {
                id = int.Parse(claim.Value);
            }
            catch (Exception)
            {
                return 0;
            }

            return id;

        }
    }
}