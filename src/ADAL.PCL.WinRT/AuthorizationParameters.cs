//----------------------------------------------------------------------
// Copyright (c) Microsoft Open Technologies, Inc.
// All Rights Reserved
// Apache License 2.0
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Microsoft.IdentityModel.Clients.ActiveDirectory
{
    /// <summary>
    /// Additional parameters used in acquiring user's authorization
    /// </summary>
    public class AuthorizationParameters : IAuthorizationParameters
    {
        public AuthorizationParameters(PromptBehavior promptBehavior, bool useCorporateNetwork)
        {
            this.PromptBehavior = promptBehavior;
            this.UseCorporateNetwork = useCorporateNetwork;
        }

        /// <summary>
        /// Gets or Sets flag to enable logged in user authentication. Note that enabling this flag requires some extra application capabilites.
        /// This flag only works in SSO mode and is ignored otherwise.
        /// </summary>
        public bool UseCorporateNetwork { get; private set; }

        /// <summary>
        /// Gets prompt behavior. If <see cref="PromptBehavior.Always"/>, asks service to show user the authentication page which gives them chance to authenticate as a different user.
        /// </summary>
        public PromptBehavior PromptBehavior { get; private set; }
    }
}