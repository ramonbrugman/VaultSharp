﻿using VaultSharp.V1.AuthMethods.AppRole;
using VaultSharp.V1.AuthMethods.AWS;
using VaultSharp.V1.AuthMethods.Azure;
using VaultSharp.V1.AuthMethods.Cert;
using VaultSharp.V1.AuthMethods.GitHub;
using VaultSharp.V1.AuthMethods.Kubernetes;
using VaultSharp.V1.AuthMethods.LDAP;
using VaultSharp.V1.AuthMethods.Okta;
using VaultSharp.V1.AuthMethods.RADIUS;
using VaultSharp.V1.AuthMethods.Token;
using VaultSharp.V1.AuthMethods.UserPass;

namespace VaultSharp.V1.AuthMethods
{
    /// <summary>
    /// 
    /// </summary>
    public interface IAuthMethod
    {
        /// <summary>
        /// 
        /// </summary>
        IAppRoleAuthMethod AppRole { get; }

        /// <summary>
        /// 
        /// </summary>
        IAWSAuthBackend AWS { get; }

        /// <summary>
        /// 
        /// </summary>
        IAzureAuthMethod Azure { get; }

        /// <summary>
        /// Hmm.
        /// </summary>
        IGitHubAuthMethod GitHub { get; }

        /// <summary>
        /// 
        /// </summary>
        IGitHubAuthMethod GoogleCloud { get; }

        /// <summary>
        /// 
        /// </summary>
        IKubernetesAuthMethod Kubernetes { get; }


        /// <summary>
        /// 
        /// </summary>
        ILDAPAuthBackend LDAP { get; }


        /// <summary>
        /// 
        /// </summary>
        IOktaAuthBackend Okta { get; }


        /// <summary>
        /// 
        /// </summary>
        IRADIUSAuthBackend RADIUS { get; }


        /// <summary>
        /// 
        /// </summary>
        ICertAuthBackend Cert { get; }


        /// <summary>
        /// 
        /// </summary>
        ITokenAuthMethod Token { get; }

        /// <summary>
        /// 
        /// </summary>
        IUserPassAuthBackend UserPass { get; }
    }
}