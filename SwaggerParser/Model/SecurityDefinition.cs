using System.Collections.Generic;

namespace ARMExplorer.SwaggerParser.Model
{

    public enum SecuritySchemeType
    {
        None,
        Basic,
        ApiKey,
        OAuth2
    }

    public enum ApiKeyLocation
    {
        None,
        Query,
        Header
    }

    public enum OAuthFlow
    {
        None,
        Implicit,
        Password,
        Application,
        AccessCode
    }


    /// <summary>
    /// Security Scheme Object - https://github.com/wordnik/swagger-spec/blob/master/versions/2.0.md#security-scheme-object-
    /// </summary>
    public class SecurityDefinition
    {
        private string _description;
        public SecuritySchemeType SecuritySchemeType { get; set; }

        public string Description
        {
            get { return _description; }
            set { _description = value.StripControlCharacters(); }
        }

        public string Name { get; set; }

        public ApiKeyLocation In { get; set; }

        public OAuthFlow Flow { get; set; }

        public string AuthorizationUrl { get; set; }

        public string TokenUrl { get; set; }

        /// <summary>
        /// Lists the available scopes for an OAuth2 security scheme. 
        /// Key is scope serviceTypeName and the value is short description
        /// </summary>
        public Dictionary<string, string> Scopes { get; set; }
    }
}