// Copyright 2020 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

using gctv = Google.Cloud.Talent.V4Beta1;

namespace Google.Cloud.Talent.V4Beta1
{
    public partial class CreateCompanyRequest
    {
        /// <summary>
        /// <see cref="TenantOrProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public TenantOrProjectName ParentAsTenantOrProjectName
        {
            get => string.IsNullOrEmpty(Parent) ? null : TenantOrProjectName.Parse(Parent);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetCompanyRequest
    {
        /// <summary>
        /// <see cref="gctv::CompanyName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gctv::CompanyName CompanyName
        {
            get => string.IsNullOrEmpty(Name) ? null : gctv::CompanyName.Parse(Name);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeleteCompanyRequest
    {
        /// <summary>
        /// <see cref="gctv::CompanyName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gctv::CompanyName CompanyName
        {
            get => string.IsNullOrEmpty(Name) ? null : gctv::CompanyName.Parse(Name);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListCompaniesRequest
    {
        /// <summary>
        /// <see cref="TenantOrProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public TenantOrProjectName ParentAsTenantOrProjectName
        {
            get => string.IsNullOrEmpty(Parent) ? null : TenantOrProjectName.Parse(Parent);
            set => Parent = value?.ToString() ?? "";
        }
    }
}
