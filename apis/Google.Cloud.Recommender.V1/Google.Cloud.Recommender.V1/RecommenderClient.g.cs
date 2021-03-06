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

using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using proto = Google.Protobuf;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using sys = System;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Cloud.Recommender.V1
{
    /// <summary>Settings for <see cref="RecommenderClient"/> instances.</summary>
    public sealed partial class RecommenderSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="RecommenderSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="RecommenderSettings"/>.</returns>
        public static RecommenderSettings GetDefault() => new RecommenderSettings();

        /// <summary>Constructs a new <see cref="RecommenderSettings"/> object with default settings.</summary>
        public RecommenderSettings()
        {
        }

        private RecommenderSettings(RecommenderSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListRecommendationsSettings = existing.ListRecommendationsSettings;
            GetRecommendationSettings = existing.GetRecommendationSettings;
            MarkRecommendationClaimedSettings = existing.MarkRecommendationClaimedSettings;
            MarkRecommendationSucceededSettings = existing.MarkRecommendationSucceededSettings;
            MarkRecommendationFailedSettings = existing.MarkRecommendationFailedSettings;
            OnCopy(existing);
        }

        partial void OnCopy(RecommenderSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RecommenderClient.ListRecommendations</c> and <c>RecommenderClient.ListRecommendationsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Initial timeout: 60000 milliseconds.</description></item>
        /// <item><description>Timeout multiplier: 1</description></item>
        /// <item><description>Timeout maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Total timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListRecommendationsSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(retryBackoff: new gaxgrpc::BackoffSettings(delay: sys::TimeSpan.FromMilliseconds(100), maxDelay: sys::TimeSpan.FromMilliseconds(60000), delayMultiplier: 1.3), timeoutBackoff: new gaxgrpc::BackoffSettings(delay: sys::TimeSpan.FromMilliseconds(60000), maxDelay: sys::TimeSpan.FromMilliseconds(60000), delayMultiplier: 1), totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)), retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable))));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RecommenderClient.GetRecommendation</c> and <c>RecommenderClient.GetRecommendationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Initial timeout: 60000 milliseconds.</description></item>
        /// <item><description>Timeout multiplier: 1</description></item>
        /// <item><description>Timeout maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Total timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetRecommendationSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(retryBackoff: new gaxgrpc::BackoffSettings(delay: sys::TimeSpan.FromMilliseconds(100), maxDelay: sys::TimeSpan.FromMilliseconds(60000), delayMultiplier: 1.3), timeoutBackoff: new gaxgrpc::BackoffSettings(delay: sys::TimeSpan.FromMilliseconds(60000), maxDelay: sys::TimeSpan.FromMilliseconds(60000), delayMultiplier: 1), totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)), retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable))));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RecommenderClient.MarkRecommendationClaimed</c> and <c>RecommenderClient.MarkRecommendationClaimedAsync</c>
        /// .
        /// </summary>
        /// <remarks>By default, retry will not be attempted.</remarks>
        public gaxgrpc::CallSettings MarkRecommendationClaimedSettings { get; set; }

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RecommenderClient.MarkRecommendationSucceeded</c> and
        /// <c>RecommenderClient.MarkRecommendationSucceededAsync</c>.
        /// </summary>
        /// <remarks>By default, retry will not be attempted.</remarks>
        public gaxgrpc::CallSettings MarkRecommendationSucceededSettings { get; set; }

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RecommenderClient.MarkRecommendationFailed</c> and <c>RecommenderClient.MarkRecommendationFailedAsync</c>
        /// .
        /// </summary>
        /// <remarks>By default, retry will not be attempted.</remarks>
        public gaxgrpc::CallSettings MarkRecommendationFailedSettings { get; set; }

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="RecommenderSettings"/> object.</returns>
        public RecommenderSettings Clone() => new RecommenderSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="RecommenderClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class RecommenderClientBuilder : gaxgrpc::ClientBuilderBase<RecommenderClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public RecommenderSettings Settings { get; set; }

        /// <inheritdoc/>
        public override RecommenderClient Build()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return RecommenderClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc/>
        public override async stt::Task<RecommenderClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return RecommenderClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc/>
        protected override gaxgrpc::ServiceEndpoint GetDefaultEndpoint() => RecommenderClient.DefaultEndpoint;

        /// <inheritdoc/>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => RecommenderClient.DefaultScopes;

        /// <inheritdoc/>
        protected override gaxgrpc::ChannelPool GetChannelPool() => RecommenderClient.ChannelPool;
    }

    /// <summary>Recommender client wrapper, for convenient use.</summary>
    public abstract partial class RecommenderClient
    {
        /// <summary>
        /// The default endpoint for the Recommender service, which is a host of "recommender.googleapis.com" and a port
        /// of 443.
        /// </summary>
        public static gaxgrpc::ServiceEndpoint DefaultEndpoint { get; } = new gaxgrpc::ServiceEndpoint("recommender.googleapis.com", 443);

        /// <summary>The default Recommender scopes.</summary>
        /// <remarks>
        /// The default Recommender scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="RecommenderClient"/>, applying defaults for all unspecified settings, 
        /// and creating a channel connecting to the given endpoint with application default credentials where 
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Cloud.Vision.V1;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// ImageAnnotatorClient client = await ImageAnnotatorClient.CreateAsync();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Cloud.Vision.V1;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     ImageAnnotatorClient.DefaultEndpoint.Host, ImageAnnotatorClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// ImageAnnotatorClient client = ImageAnnotatorClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// await channel.ShutdownAsync();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="RecommenderSettings"/>.</param>
        /// <returns>The task representing the created <see cref="RecommenderClient"/>.</returns>
        public static async stt::Task<RecommenderClient> CreateAsync(gaxgrpc::ServiceEndpoint endpoint = null, RecommenderSettings settings = null)
        {
            grpccore::Channel channel = await ChannelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="RecommenderClient"/>, applying defaults for all unspecified settings, and
        /// creating a channel connecting to the given endpoint with application default credentials where necessary.
        /// See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Cloud.Vision.V1;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// ImageAnnotatorClient client = ImageAnnotatorClient.Create();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Cloud.Vision.V1;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     ImageAnnotatorClient.DefaultEndpoint.Host, ImageAnnotatorClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// ImageAnnotatorClient client = ImageAnnotatorClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// channel.ShutdownAsync().Wait();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="RecommenderSettings"/>.</param>
        /// <returns>The created <see cref="RecommenderClient"/>.</returns>
        public static RecommenderClient Create(gaxgrpc::ServiceEndpoint endpoint = null, RecommenderSettings settings = null)
        {
            grpccore::Channel channel = ChannelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="RecommenderClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="grpccore::Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="RecommenderSettings"/>.</param>
        /// <returns>The created <see cref="RecommenderClient"/>.</returns>
        public static RecommenderClient Create(grpccore::Channel channel, RecommenderSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(channel, nameof(channel));
            return Create(new grpccore::DefaultCallInvoker(channel), settings);
        }

        /// <summary>
        /// Creates a <see cref="RecommenderClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="RecommenderSettings"/>.</param>
        /// <returns>The created <see cref="RecommenderClient"/>.</returns>
        public static RecommenderClient Create(grpccore::CallInvoker callInvoker, RecommenderSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            Recommender.RecommenderClient grpcClient = new Recommender.RecommenderClient(callInvoker);
            return new RecommenderClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by
        /// <see cref="Create(grpccore::CallInvoker,RecommenderSettings)"/> and
        /// <see cref="CreateAsync(gaxgrpc::ServiceEndpoint,RecommenderSettings)"/>. Channels which weren't
        /// automatically created are not affected.
        /// </summary>
        /// <remarks>
        /// After calling this method, further calls to <see cref="Create(grpccore::CallInvoker,RecommenderSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint,RecommenderSettings)"/> will create new channels, which
        /// could in turn be shut down by another call to this method.
        /// </remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => ChannelPool.ShutdownChannelsAsync();

        /// <summary>The underlying gRPC Recommender client</summary>
        public virtual Recommender.RecommenderClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists recommendations for a Cloud project. Requires the recommender.*.list
        /// IAM permission for the specified recommender.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Recommendation"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRecommendationsResponse, Recommendation> ListRecommendations(ListRecommendationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists recommendations for a Cloud project. Requires the recommender.*.list
        /// IAM permission for the specified recommender.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Recommendation"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRecommendationsResponse, Recommendation> ListRecommendationsAsync(ListRecommendationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists recommendations for a Cloud project. Requires the recommender.*.list
        /// IAM permission for the specified recommender.
        /// </summary>
        /// <param name="parent">
        /// Required. The container resource on which to execute the request.
        /// Acceptable formats:
        /// 
        /// 1.
        /// "projects/[PROJECT_NUMBER]/locations/[LOCATION]/recommenders/[RECOMMENDER_ID]",
        /// 
        /// LOCATION here refers to GCP Locations:
        /// https://cloud.google.com/about/locations/
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Recommendation"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRecommendationsResponse, Recommendation> ListRecommendations(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListRecommendations(new ListRecommendationsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists recommendations for a Cloud project. Requires the recommender.*.list
        /// IAM permission for the specified recommender.
        /// </summary>
        /// <param name="parent">
        /// Required. The container resource on which to execute the request.
        /// Acceptable formats:
        /// 
        /// 1.
        /// "projects/[PROJECT_NUMBER]/locations/[LOCATION]/recommenders/[RECOMMENDER_ID]",
        /// 
        /// LOCATION here refers to GCP Locations:
        /// https://cloud.google.com/about/locations/
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Recommendation"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRecommendationsResponse, Recommendation> ListRecommendationsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListRecommendationsAsync(new ListRecommendationsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists recommendations for a Cloud project. Requires the recommender.*.list
        /// IAM permission for the specified recommender.
        /// </summary>
        /// <param name="parent">
        /// Required. The container resource on which to execute the request.
        /// Acceptable formats:
        /// 
        /// 1.
        /// "projects/[PROJECT_NUMBER]/locations/[LOCATION]/recommenders/[RECOMMENDER_ID]",
        /// 
        /// LOCATION here refers to GCP Locations:
        /// https://cloud.google.com/about/locations/
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Recommendation"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRecommendationsResponse, Recommendation> ListRecommendations(RecommenderName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListRecommendations(new ListRecommendationsRequest
            {
                ParentAsRecommenderName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists recommendations for a Cloud project. Requires the recommender.*.list
        /// IAM permission for the specified recommender.
        /// </summary>
        /// <param name="parent">
        /// Required. The container resource on which to execute the request.
        /// Acceptable formats:
        /// 
        /// 1.
        /// "projects/[PROJECT_NUMBER]/locations/[LOCATION]/recommenders/[RECOMMENDER_ID]",
        /// 
        /// LOCATION here refers to GCP Locations:
        /// https://cloud.google.com/about/locations/
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Recommendation"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRecommendationsResponse, Recommendation> ListRecommendationsAsync(RecommenderName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListRecommendationsAsync(new ListRecommendationsRequest
            {
                ParentAsRecommenderName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists recommendations for a Cloud project. Requires the recommender.*.list
        /// IAM permission for the specified recommender.
        /// </summary>
        /// <param name="parent">
        /// Required. The container resource on which to execute the request.
        /// Acceptable formats:
        /// 
        /// 1.
        /// "projects/[PROJECT_NUMBER]/locations/[LOCATION]/recommenders/[RECOMMENDER_ID]",
        /// 
        /// LOCATION here refers to GCP Locations:
        /// https://cloud.google.com/about/locations/
        /// </param>
        /// <param name="filter">
        /// Filter expression to restrict the recommendations returned. Supported
        /// filter fields: state_info.state
        /// Eg: `state_info.state:"DISMISSED" or state_info.state:"FAILED"
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Recommendation"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRecommendationsResponse, Recommendation> ListRecommendations(string parent, string filter, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListRecommendations(new ListRecommendationsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Filter = filter ?? "",
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists recommendations for a Cloud project. Requires the recommender.*.list
        /// IAM permission for the specified recommender.
        /// </summary>
        /// <param name="parent">
        /// Required. The container resource on which to execute the request.
        /// Acceptable formats:
        /// 
        /// 1.
        /// "projects/[PROJECT_NUMBER]/locations/[LOCATION]/recommenders/[RECOMMENDER_ID]",
        /// 
        /// LOCATION here refers to GCP Locations:
        /// https://cloud.google.com/about/locations/
        /// </param>
        /// <param name="filter">
        /// Filter expression to restrict the recommendations returned. Supported
        /// filter fields: state_info.state
        /// Eg: `state_info.state:"DISMISSED" or state_info.state:"FAILED"
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Recommendation"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRecommendationsResponse, Recommendation> ListRecommendationsAsync(string parent, string filter, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListRecommendationsAsync(new ListRecommendationsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Filter = filter ?? "",
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists recommendations for a Cloud project. Requires the recommender.*.list
        /// IAM permission for the specified recommender.
        /// </summary>
        /// <param name="parent">
        /// Required. The container resource on which to execute the request.
        /// Acceptable formats:
        /// 
        /// 1.
        /// "projects/[PROJECT_NUMBER]/locations/[LOCATION]/recommenders/[RECOMMENDER_ID]",
        /// 
        /// LOCATION here refers to GCP Locations:
        /// https://cloud.google.com/about/locations/
        /// </param>
        /// <param name="filter">
        /// Filter expression to restrict the recommendations returned. Supported
        /// filter fields: state_info.state
        /// Eg: `state_info.state:"DISMISSED" or state_info.state:"FAILED"
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Recommendation"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRecommendationsResponse, Recommendation> ListRecommendations(RecommenderName parent, string filter, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListRecommendations(new ListRecommendationsRequest
            {
                ParentAsRecommenderName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Filter = filter ?? "",
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists recommendations for a Cloud project. Requires the recommender.*.list
        /// IAM permission for the specified recommender.
        /// </summary>
        /// <param name="parent">
        /// Required. The container resource on which to execute the request.
        /// Acceptable formats:
        /// 
        /// 1.
        /// "projects/[PROJECT_NUMBER]/locations/[LOCATION]/recommenders/[RECOMMENDER_ID]",
        /// 
        /// LOCATION here refers to GCP Locations:
        /// https://cloud.google.com/about/locations/
        /// </param>
        /// <param name="filter">
        /// Filter expression to restrict the recommendations returned. Supported
        /// filter fields: state_info.state
        /// Eg: `state_info.state:"DISMISSED" or state_info.state:"FAILED"
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Recommendation"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRecommendationsResponse, Recommendation> ListRecommendationsAsync(RecommenderName parent, string filter, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListRecommendationsAsync(new ListRecommendationsRequest
            {
                ParentAsRecommenderName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Filter = filter ?? "",
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Gets the requested recommendation. Requires the recommender.*.get
        /// IAM permission for the specified recommender.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Recommendation GetRecommendation(GetRecommendationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the requested recommendation. Requires the recommender.*.get
        /// IAM permission for the specified recommender.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Recommendation> GetRecommendationAsync(GetRecommendationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the requested recommendation. Requires the recommender.*.get
        /// IAM permission for the specified recommender.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Recommendation> GetRecommendationAsync(GetRecommendationRequest request, st::CancellationToken cancellationToken) =>
            GetRecommendationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the requested recommendation. Requires the recommender.*.get
        /// IAM permission for the specified recommender.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the recommendation.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Recommendation GetRecommendation(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetRecommendation(new GetRecommendationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the requested recommendation. Requires the recommender.*.get
        /// IAM permission for the specified recommender.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the recommendation.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Recommendation> GetRecommendationAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetRecommendationAsync(new GetRecommendationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the requested recommendation. Requires the recommender.*.get
        /// IAM permission for the specified recommender.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the recommendation.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Recommendation> GetRecommendationAsync(string name, st::CancellationToken cancellationToken) =>
            GetRecommendationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the requested recommendation. Requires the recommender.*.get
        /// IAM permission for the specified recommender.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the recommendation.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Recommendation GetRecommendation(RecommendationName name, gaxgrpc::CallSettings callSettings = null) =>
            GetRecommendation(new GetRecommendationRequest
            {
                RecommendationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the requested recommendation. Requires the recommender.*.get
        /// IAM permission for the specified recommender.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the recommendation.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Recommendation> GetRecommendationAsync(RecommendationName name, gaxgrpc::CallSettings callSettings = null) =>
            GetRecommendationAsync(new GetRecommendationRequest
            {
                RecommendationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the requested recommendation. Requires the recommender.*.get
        /// IAM permission for the specified recommender.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the recommendation.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Recommendation> GetRecommendationAsync(RecommendationName name, st::CancellationToken cancellationToken) =>
            GetRecommendationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Mark the Recommendation State as Claimed. Users can use this method to
        /// indicate to the Recommender API that they are starting to apply the
        /// recommendation themselves. This stops the recommendation content from being
        /// updated.
        /// 
        /// MarkRecommendationClaimed can be applied to recommendations in CLAIMED,
        /// SUCCEEDED, FAILED, or ACTIVE state.
        /// 
        /// Requires the recommender.*.update IAM permission for the specified
        /// recommender.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Recommendation MarkRecommendationClaimed(MarkRecommendationClaimedRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Mark the Recommendation State as Claimed. Users can use this method to
        /// indicate to the Recommender API that they are starting to apply the
        /// recommendation themselves. This stops the recommendation content from being
        /// updated.
        /// 
        /// MarkRecommendationClaimed can be applied to recommendations in CLAIMED,
        /// SUCCEEDED, FAILED, or ACTIVE state.
        /// 
        /// Requires the recommender.*.update IAM permission for the specified
        /// recommender.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Recommendation> MarkRecommendationClaimedAsync(MarkRecommendationClaimedRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Mark the Recommendation State as Claimed. Users can use this method to
        /// indicate to the Recommender API that they are starting to apply the
        /// recommendation themselves. This stops the recommendation content from being
        /// updated.
        /// 
        /// MarkRecommendationClaimed can be applied to recommendations in CLAIMED,
        /// SUCCEEDED, FAILED, or ACTIVE state.
        /// 
        /// Requires the recommender.*.update IAM permission for the specified
        /// recommender.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Recommendation> MarkRecommendationClaimedAsync(MarkRecommendationClaimedRequest request, st::CancellationToken cancellationToken) =>
            MarkRecommendationClaimedAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Mark the Recommendation State as Claimed. Users can use this method to
        /// indicate to the Recommender API that they are starting to apply the
        /// recommendation themselves. This stops the recommendation content from being
        /// updated.
        /// 
        /// MarkRecommendationClaimed can be applied to recommendations in CLAIMED,
        /// SUCCEEDED, FAILED, or ACTIVE state.
        /// 
        /// Requires the recommender.*.update IAM permission for the specified
        /// recommender.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the recommendation.
        /// </param>
        /// <param name="stateMetadata">
        /// State properties to include with this state. Overwrites any existing
        /// `state_metadata`.
        /// Keys must match the regex /^[a-z0-9][a-z0-9_.-]{0,62}$/.
        /// Values must match the regex /^[a-zA-Z0-9_./-]{0,255}$/.
        /// </param>
        /// <param name="etag">
        /// Required. Fingerprint of the Recommendation. Provides optimistic locking.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Recommendation MarkRecommendationClaimed(string name, scg::IDictionary<string, string> stateMetadata, string etag, gaxgrpc::CallSettings callSettings = null) =>
            MarkRecommendationClaimed(new MarkRecommendationClaimedRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                StateMetadata =
                {
                    stateMetadata ?? new scg::Dictionary<string, string>(),
                },
                Etag = gax::GaxPreconditions.CheckNotNullOrEmpty(etag, nameof(etag)),
            }, callSettings);

        /// <summary>
        /// Mark the Recommendation State as Claimed. Users can use this method to
        /// indicate to the Recommender API that they are starting to apply the
        /// recommendation themselves. This stops the recommendation content from being
        /// updated.
        /// 
        /// MarkRecommendationClaimed can be applied to recommendations in CLAIMED,
        /// SUCCEEDED, FAILED, or ACTIVE state.
        /// 
        /// Requires the recommender.*.update IAM permission for the specified
        /// recommender.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the recommendation.
        /// </param>
        /// <param name="stateMetadata">
        /// State properties to include with this state. Overwrites any existing
        /// `state_metadata`.
        /// Keys must match the regex /^[a-z0-9][a-z0-9_.-]{0,62}$/.
        /// Values must match the regex /^[a-zA-Z0-9_./-]{0,255}$/.
        /// </param>
        /// <param name="etag">
        /// Required. Fingerprint of the Recommendation. Provides optimistic locking.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Recommendation> MarkRecommendationClaimedAsync(string name, scg::IDictionary<string, string> stateMetadata, string etag, gaxgrpc::CallSettings callSettings = null) =>
            MarkRecommendationClaimedAsync(new MarkRecommendationClaimedRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                StateMetadata =
                {
                    stateMetadata ?? new scg::Dictionary<string, string>(),
                },
                Etag = gax::GaxPreconditions.CheckNotNullOrEmpty(etag, nameof(etag)),
            }, callSettings);

        /// <summary>
        /// Mark the Recommendation State as Claimed. Users can use this method to
        /// indicate to the Recommender API that they are starting to apply the
        /// recommendation themselves. This stops the recommendation content from being
        /// updated.
        /// 
        /// MarkRecommendationClaimed can be applied to recommendations in CLAIMED,
        /// SUCCEEDED, FAILED, or ACTIVE state.
        /// 
        /// Requires the recommender.*.update IAM permission for the specified
        /// recommender.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the recommendation.
        /// </param>
        /// <param name="stateMetadata">
        /// State properties to include with this state. Overwrites any existing
        /// `state_metadata`.
        /// Keys must match the regex /^[a-z0-9][a-z0-9_.-]{0,62}$/.
        /// Values must match the regex /^[a-zA-Z0-9_./-]{0,255}$/.
        /// </param>
        /// <param name="etag">
        /// Required. Fingerprint of the Recommendation. Provides optimistic locking.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Recommendation> MarkRecommendationClaimedAsync(string name, scg::IDictionary<string, string> stateMetadata, string etag, st::CancellationToken cancellationToken) =>
            MarkRecommendationClaimedAsync(name, stateMetadata, etag, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Mark the Recommendation State as Claimed. Users can use this method to
        /// indicate to the Recommender API that they are starting to apply the
        /// recommendation themselves. This stops the recommendation content from being
        /// updated.
        /// 
        /// MarkRecommendationClaimed can be applied to recommendations in CLAIMED,
        /// SUCCEEDED, FAILED, or ACTIVE state.
        /// 
        /// Requires the recommender.*.update IAM permission for the specified
        /// recommender.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the recommendation.
        /// </param>
        /// <param name="stateMetadata">
        /// State properties to include with this state. Overwrites any existing
        /// `state_metadata`.
        /// Keys must match the regex /^[a-z0-9][a-z0-9_.-]{0,62}$/.
        /// Values must match the regex /^[a-zA-Z0-9_./-]{0,255}$/.
        /// </param>
        /// <param name="etag">
        /// Required. Fingerprint of the Recommendation. Provides optimistic locking.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Recommendation MarkRecommendationClaimed(RecommendationName name, scg::IDictionary<string, string> stateMetadata, string etag, gaxgrpc::CallSettings callSettings = null) =>
            MarkRecommendationClaimed(new MarkRecommendationClaimedRequest
            {
                RecommendationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                StateMetadata =
                {
                    stateMetadata ?? new scg::Dictionary<string, string>(),
                },
                Etag = gax::GaxPreconditions.CheckNotNullOrEmpty(etag, nameof(etag)),
            }, callSettings);

        /// <summary>
        /// Mark the Recommendation State as Claimed. Users can use this method to
        /// indicate to the Recommender API that they are starting to apply the
        /// recommendation themselves. This stops the recommendation content from being
        /// updated.
        /// 
        /// MarkRecommendationClaimed can be applied to recommendations in CLAIMED,
        /// SUCCEEDED, FAILED, or ACTIVE state.
        /// 
        /// Requires the recommender.*.update IAM permission for the specified
        /// recommender.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the recommendation.
        /// </param>
        /// <param name="stateMetadata">
        /// State properties to include with this state. Overwrites any existing
        /// `state_metadata`.
        /// Keys must match the regex /^[a-z0-9][a-z0-9_.-]{0,62}$/.
        /// Values must match the regex /^[a-zA-Z0-9_./-]{0,255}$/.
        /// </param>
        /// <param name="etag">
        /// Required. Fingerprint of the Recommendation. Provides optimistic locking.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Recommendation> MarkRecommendationClaimedAsync(RecommendationName name, scg::IDictionary<string, string> stateMetadata, string etag, gaxgrpc::CallSettings callSettings = null) =>
            MarkRecommendationClaimedAsync(new MarkRecommendationClaimedRequest
            {
                RecommendationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                StateMetadata =
                {
                    stateMetadata ?? new scg::Dictionary<string, string>(),
                },
                Etag = gax::GaxPreconditions.CheckNotNullOrEmpty(etag, nameof(etag)),
            }, callSettings);

        /// <summary>
        /// Mark the Recommendation State as Claimed. Users can use this method to
        /// indicate to the Recommender API that they are starting to apply the
        /// recommendation themselves. This stops the recommendation content from being
        /// updated.
        /// 
        /// MarkRecommendationClaimed can be applied to recommendations in CLAIMED,
        /// SUCCEEDED, FAILED, or ACTIVE state.
        /// 
        /// Requires the recommender.*.update IAM permission for the specified
        /// recommender.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the recommendation.
        /// </param>
        /// <param name="stateMetadata">
        /// State properties to include with this state. Overwrites any existing
        /// `state_metadata`.
        /// Keys must match the regex /^[a-z0-9][a-z0-9_.-]{0,62}$/.
        /// Values must match the regex /^[a-zA-Z0-9_./-]{0,255}$/.
        /// </param>
        /// <param name="etag">
        /// Required. Fingerprint of the Recommendation. Provides optimistic locking.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Recommendation> MarkRecommendationClaimedAsync(RecommendationName name, scg::IDictionary<string, string> stateMetadata, string etag, st::CancellationToken cancellationToken) =>
            MarkRecommendationClaimedAsync(name, stateMetadata, etag, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Mark the Recommendation State as Succeeded. Users can use this method to
        /// indicate to the Recommender API that they have applied the recommendation
        /// themselves, and the operation was successful. This stops the recommendation
        /// content from being updated.
        /// 
        /// MarkRecommendationSucceeded can be applied to recommendations in ACTIVE,
        /// CLAIMED, SUCCEEDED, or FAILED state.
        /// 
        /// Requires the recommender.*.update IAM permission for the specified
        /// recommender.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Recommendation MarkRecommendationSucceeded(MarkRecommendationSucceededRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Mark the Recommendation State as Succeeded. Users can use this method to
        /// indicate to the Recommender API that they have applied the recommendation
        /// themselves, and the operation was successful. This stops the recommendation
        /// content from being updated.
        /// 
        /// MarkRecommendationSucceeded can be applied to recommendations in ACTIVE,
        /// CLAIMED, SUCCEEDED, or FAILED state.
        /// 
        /// Requires the recommender.*.update IAM permission for the specified
        /// recommender.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Recommendation> MarkRecommendationSucceededAsync(MarkRecommendationSucceededRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Mark the Recommendation State as Succeeded. Users can use this method to
        /// indicate to the Recommender API that they have applied the recommendation
        /// themselves, and the operation was successful. This stops the recommendation
        /// content from being updated.
        /// 
        /// MarkRecommendationSucceeded can be applied to recommendations in ACTIVE,
        /// CLAIMED, SUCCEEDED, or FAILED state.
        /// 
        /// Requires the recommender.*.update IAM permission for the specified
        /// recommender.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Recommendation> MarkRecommendationSucceededAsync(MarkRecommendationSucceededRequest request, st::CancellationToken cancellationToken) =>
            MarkRecommendationSucceededAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Mark the Recommendation State as Succeeded. Users can use this method to
        /// indicate to the Recommender API that they have applied the recommendation
        /// themselves, and the operation was successful. This stops the recommendation
        /// content from being updated.
        /// 
        /// MarkRecommendationSucceeded can be applied to recommendations in ACTIVE,
        /// CLAIMED, SUCCEEDED, or FAILED state.
        /// 
        /// Requires the recommender.*.update IAM permission for the specified
        /// recommender.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the recommendation.
        /// </param>
        /// <param name="stateMetadata">
        /// State properties to include with this state. Overwrites any existing
        /// `state_metadata`.
        /// Keys must match the regex /^[a-z0-9][a-z0-9_.-]{0,62}$/.
        /// Values must match the regex /^[a-zA-Z0-9_./-]{0,255}$/.
        /// </param>
        /// <param name="etag">
        /// Required. Fingerprint of the Recommendation. Provides optimistic locking.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Recommendation MarkRecommendationSucceeded(string name, scg::IDictionary<string, string> stateMetadata, string etag, gaxgrpc::CallSettings callSettings = null) =>
            MarkRecommendationSucceeded(new MarkRecommendationSucceededRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                StateMetadata =
                {
                    stateMetadata ?? new scg::Dictionary<string, string>(),
                },
                Etag = gax::GaxPreconditions.CheckNotNullOrEmpty(etag, nameof(etag)),
            }, callSettings);

        /// <summary>
        /// Mark the Recommendation State as Succeeded. Users can use this method to
        /// indicate to the Recommender API that they have applied the recommendation
        /// themselves, and the operation was successful. This stops the recommendation
        /// content from being updated.
        /// 
        /// MarkRecommendationSucceeded can be applied to recommendations in ACTIVE,
        /// CLAIMED, SUCCEEDED, or FAILED state.
        /// 
        /// Requires the recommender.*.update IAM permission for the specified
        /// recommender.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the recommendation.
        /// </param>
        /// <param name="stateMetadata">
        /// State properties to include with this state. Overwrites any existing
        /// `state_metadata`.
        /// Keys must match the regex /^[a-z0-9][a-z0-9_.-]{0,62}$/.
        /// Values must match the regex /^[a-zA-Z0-9_./-]{0,255}$/.
        /// </param>
        /// <param name="etag">
        /// Required. Fingerprint of the Recommendation. Provides optimistic locking.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Recommendation> MarkRecommendationSucceededAsync(string name, scg::IDictionary<string, string> stateMetadata, string etag, gaxgrpc::CallSettings callSettings = null) =>
            MarkRecommendationSucceededAsync(new MarkRecommendationSucceededRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                StateMetadata =
                {
                    stateMetadata ?? new scg::Dictionary<string, string>(),
                },
                Etag = gax::GaxPreconditions.CheckNotNullOrEmpty(etag, nameof(etag)),
            }, callSettings);

        /// <summary>
        /// Mark the Recommendation State as Succeeded. Users can use this method to
        /// indicate to the Recommender API that they have applied the recommendation
        /// themselves, and the operation was successful. This stops the recommendation
        /// content from being updated.
        /// 
        /// MarkRecommendationSucceeded can be applied to recommendations in ACTIVE,
        /// CLAIMED, SUCCEEDED, or FAILED state.
        /// 
        /// Requires the recommender.*.update IAM permission for the specified
        /// recommender.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the recommendation.
        /// </param>
        /// <param name="stateMetadata">
        /// State properties to include with this state. Overwrites any existing
        /// `state_metadata`.
        /// Keys must match the regex /^[a-z0-9][a-z0-9_.-]{0,62}$/.
        /// Values must match the regex /^[a-zA-Z0-9_./-]{0,255}$/.
        /// </param>
        /// <param name="etag">
        /// Required. Fingerprint of the Recommendation. Provides optimistic locking.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Recommendation> MarkRecommendationSucceededAsync(string name, scg::IDictionary<string, string> stateMetadata, string etag, st::CancellationToken cancellationToken) =>
            MarkRecommendationSucceededAsync(name, stateMetadata, etag, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Mark the Recommendation State as Succeeded. Users can use this method to
        /// indicate to the Recommender API that they have applied the recommendation
        /// themselves, and the operation was successful. This stops the recommendation
        /// content from being updated.
        /// 
        /// MarkRecommendationSucceeded can be applied to recommendations in ACTIVE,
        /// CLAIMED, SUCCEEDED, or FAILED state.
        /// 
        /// Requires the recommender.*.update IAM permission for the specified
        /// recommender.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the recommendation.
        /// </param>
        /// <param name="stateMetadata">
        /// State properties to include with this state. Overwrites any existing
        /// `state_metadata`.
        /// Keys must match the regex /^[a-z0-9][a-z0-9_.-]{0,62}$/.
        /// Values must match the regex /^[a-zA-Z0-9_./-]{0,255}$/.
        /// </param>
        /// <param name="etag">
        /// Required. Fingerprint of the Recommendation. Provides optimistic locking.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Recommendation MarkRecommendationSucceeded(RecommendationName name, scg::IDictionary<string, string> stateMetadata, string etag, gaxgrpc::CallSettings callSettings = null) =>
            MarkRecommendationSucceeded(new MarkRecommendationSucceededRequest
            {
                RecommendationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                StateMetadata =
                {
                    stateMetadata ?? new scg::Dictionary<string, string>(),
                },
                Etag = gax::GaxPreconditions.CheckNotNullOrEmpty(etag, nameof(etag)),
            }, callSettings);

        /// <summary>
        /// Mark the Recommendation State as Succeeded. Users can use this method to
        /// indicate to the Recommender API that they have applied the recommendation
        /// themselves, and the operation was successful. This stops the recommendation
        /// content from being updated.
        /// 
        /// MarkRecommendationSucceeded can be applied to recommendations in ACTIVE,
        /// CLAIMED, SUCCEEDED, or FAILED state.
        /// 
        /// Requires the recommender.*.update IAM permission for the specified
        /// recommender.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the recommendation.
        /// </param>
        /// <param name="stateMetadata">
        /// State properties to include with this state. Overwrites any existing
        /// `state_metadata`.
        /// Keys must match the regex /^[a-z0-9][a-z0-9_.-]{0,62}$/.
        /// Values must match the regex /^[a-zA-Z0-9_./-]{0,255}$/.
        /// </param>
        /// <param name="etag">
        /// Required. Fingerprint of the Recommendation. Provides optimistic locking.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Recommendation> MarkRecommendationSucceededAsync(RecommendationName name, scg::IDictionary<string, string> stateMetadata, string etag, gaxgrpc::CallSettings callSettings = null) =>
            MarkRecommendationSucceededAsync(new MarkRecommendationSucceededRequest
            {
                RecommendationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                StateMetadata =
                {
                    stateMetadata ?? new scg::Dictionary<string, string>(),
                },
                Etag = gax::GaxPreconditions.CheckNotNullOrEmpty(etag, nameof(etag)),
            }, callSettings);

        /// <summary>
        /// Mark the Recommendation State as Succeeded. Users can use this method to
        /// indicate to the Recommender API that they have applied the recommendation
        /// themselves, and the operation was successful. This stops the recommendation
        /// content from being updated.
        /// 
        /// MarkRecommendationSucceeded can be applied to recommendations in ACTIVE,
        /// CLAIMED, SUCCEEDED, or FAILED state.
        /// 
        /// Requires the recommender.*.update IAM permission for the specified
        /// recommender.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the recommendation.
        /// </param>
        /// <param name="stateMetadata">
        /// State properties to include with this state. Overwrites any existing
        /// `state_metadata`.
        /// Keys must match the regex /^[a-z0-9][a-z0-9_.-]{0,62}$/.
        /// Values must match the regex /^[a-zA-Z0-9_./-]{0,255}$/.
        /// </param>
        /// <param name="etag">
        /// Required. Fingerprint of the Recommendation. Provides optimistic locking.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Recommendation> MarkRecommendationSucceededAsync(RecommendationName name, scg::IDictionary<string, string> stateMetadata, string etag, st::CancellationToken cancellationToken) =>
            MarkRecommendationSucceededAsync(name, stateMetadata, etag, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Mark the Recommendation State as Failed. Users can use this method to
        /// indicate to the Recommender API that they have applied the recommendation
        /// themselves, and the operation failed. This stops the recommendation content
        /// from being updated.
        /// 
        /// MarkRecommendationFailed can be applied to recommendations in ACTIVE,
        /// CLAIMED, SUCCEEDED, or FAILED state.
        /// 
        /// Requires the recommender.*.update IAM permission for the specified
        /// recommender.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Recommendation MarkRecommendationFailed(MarkRecommendationFailedRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Mark the Recommendation State as Failed. Users can use this method to
        /// indicate to the Recommender API that they have applied the recommendation
        /// themselves, and the operation failed. This stops the recommendation content
        /// from being updated.
        /// 
        /// MarkRecommendationFailed can be applied to recommendations in ACTIVE,
        /// CLAIMED, SUCCEEDED, or FAILED state.
        /// 
        /// Requires the recommender.*.update IAM permission for the specified
        /// recommender.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Recommendation> MarkRecommendationFailedAsync(MarkRecommendationFailedRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Mark the Recommendation State as Failed. Users can use this method to
        /// indicate to the Recommender API that they have applied the recommendation
        /// themselves, and the operation failed. This stops the recommendation content
        /// from being updated.
        /// 
        /// MarkRecommendationFailed can be applied to recommendations in ACTIVE,
        /// CLAIMED, SUCCEEDED, or FAILED state.
        /// 
        /// Requires the recommender.*.update IAM permission for the specified
        /// recommender.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Recommendation> MarkRecommendationFailedAsync(MarkRecommendationFailedRequest request, st::CancellationToken cancellationToken) =>
            MarkRecommendationFailedAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Mark the Recommendation State as Failed. Users can use this method to
        /// indicate to the Recommender API that they have applied the recommendation
        /// themselves, and the operation failed. This stops the recommendation content
        /// from being updated.
        /// 
        /// MarkRecommendationFailed can be applied to recommendations in ACTIVE,
        /// CLAIMED, SUCCEEDED, or FAILED state.
        /// 
        /// Requires the recommender.*.update IAM permission for the specified
        /// recommender.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the recommendation.
        /// </param>
        /// <param name="stateMetadata">
        /// State properties to include with this state. Overwrites any existing
        /// `state_metadata`.
        /// Keys must match the regex /^[a-z0-9][a-z0-9_.-]{0,62}$/.
        /// Values must match the regex /^[a-zA-Z0-9_./-]{0,255}$/.
        /// </param>
        /// <param name="etag">
        /// Required. Fingerprint of the Recommendation. Provides optimistic locking.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Recommendation MarkRecommendationFailed(string name, scg::IDictionary<string, string> stateMetadata, string etag, gaxgrpc::CallSettings callSettings = null) =>
            MarkRecommendationFailed(new MarkRecommendationFailedRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                StateMetadata =
                {
                    stateMetadata ?? new scg::Dictionary<string, string>(),
                },
                Etag = gax::GaxPreconditions.CheckNotNullOrEmpty(etag, nameof(etag)),
            }, callSettings);

        /// <summary>
        /// Mark the Recommendation State as Failed. Users can use this method to
        /// indicate to the Recommender API that they have applied the recommendation
        /// themselves, and the operation failed. This stops the recommendation content
        /// from being updated.
        /// 
        /// MarkRecommendationFailed can be applied to recommendations in ACTIVE,
        /// CLAIMED, SUCCEEDED, or FAILED state.
        /// 
        /// Requires the recommender.*.update IAM permission for the specified
        /// recommender.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the recommendation.
        /// </param>
        /// <param name="stateMetadata">
        /// State properties to include with this state. Overwrites any existing
        /// `state_metadata`.
        /// Keys must match the regex /^[a-z0-9][a-z0-9_.-]{0,62}$/.
        /// Values must match the regex /^[a-zA-Z0-9_./-]{0,255}$/.
        /// </param>
        /// <param name="etag">
        /// Required. Fingerprint of the Recommendation. Provides optimistic locking.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Recommendation> MarkRecommendationFailedAsync(string name, scg::IDictionary<string, string> stateMetadata, string etag, gaxgrpc::CallSettings callSettings = null) =>
            MarkRecommendationFailedAsync(new MarkRecommendationFailedRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                StateMetadata =
                {
                    stateMetadata ?? new scg::Dictionary<string, string>(),
                },
                Etag = gax::GaxPreconditions.CheckNotNullOrEmpty(etag, nameof(etag)),
            }, callSettings);

        /// <summary>
        /// Mark the Recommendation State as Failed. Users can use this method to
        /// indicate to the Recommender API that they have applied the recommendation
        /// themselves, and the operation failed. This stops the recommendation content
        /// from being updated.
        /// 
        /// MarkRecommendationFailed can be applied to recommendations in ACTIVE,
        /// CLAIMED, SUCCEEDED, or FAILED state.
        /// 
        /// Requires the recommender.*.update IAM permission for the specified
        /// recommender.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the recommendation.
        /// </param>
        /// <param name="stateMetadata">
        /// State properties to include with this state. Overwrites any existing
        /// `state_metadata`.
        /// Keys must match the regex /^[a-z0-9][a-z0-9_.-]{0,62}$/.
        /// Values must match the regex /^[a-zA-Z0-9_./-]{0,255}$/.
        /// </param>
        /// <param name="etag">
        /// Required. Fingerprint of the Recommendation. Provides optimistic locking.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Recommendation> MarkRecommendationFailedAsync(string name, scg::IDictionary<string, string> stateMetadata, string etag, st::CancellationToken cancellationToken) =>
            MarkRecommendationFailedAsync(name, stateMetadata, etag, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Mark the Recommendation State as Failed. Users can use this method to
        /// indicate to the Recommender API that they have applied the recommendation
        /// themselves, and the operation failed. This stops the recommendation content
        /// from being updated.
        /// 
        /// MarkRecommendationFailed can be applied to recommendations in ACTIVE,
        /// CLAIMED, SUCCEEDED, or FAILED state.
        /// 
        /// Requires the recommender.*.update IAM permission for the specified
        /// recommender.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the recommendation.
        /// </param>
        /// <param name="stateMetadata">
        /// State properties to include with this state. Overwrites any existing
        /// `state_metadata`.
        /// Keys must match the regex /^[a-z0-9][a-z0-9_.-]{0,62}$/.
        /// Values must match the regex /^[a-zA-Z0-9_./-]{0,255}$/.
        /// </param>
        /// <param name="etag">
        /// Required. Fingerprint of the Recommendation. Provides optimistic locking.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Recommendation MarkRecommendationFailed(RecommendationName name, scg::IDictionary<string, string> stateMetadata, string etag, gaxgrpc::CallSettings callSettings = null) =>
            MarkRecommendationFailed(new MarkRecommendationFailedRequest
            {
                RecommendationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                StateMetadata =
                {
                    stateMetadata ?? new scg::Dictionary<string, string>(),
                },
                Etag = gax::GaxPreconditions.CheckNotNullOrEmpty(etag, nameof(etag)),
            }, callSettings);

        /// <summary>
        /// Mark the Recommendation State as Failed. Users can use this method to
        /// indicate to the Recommender API that they have applied the recommendation
        /// themselves, and the operation failed. This stops the recommendation content
        /// from being updated.
        /// 
        /// MarkRecommendationFailed can be applied to recommendations in ACTIVE,
        /// CLAIMED, SUCCEEDED, or FAILED state.
        /// 
        /// Requires the recommender.*.update IAM permission for the specified
        /// recommender.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the recommendation.
        /// </param>
        /// <param name="stateMetadata">
        /// State properties to include with this state. Overwrites any existing
        /// `state_metadata`.
        /// Keys must match the regex /^[a-z0-9][a-z0-9_.-]{0,62}$/.
        /// Values must match the regex /^[a-zA-Z0-9_./-]{0,255}$/.
        /// </param>
        /// <param name="etag">
        /// Required. Fingerprint of the Recommendation. Provides optimistic locking.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Recommendation> MarkRecommendationFailedAsync(RecommendationName name, scg::IDictionary<string, string> stateMetadata, string etag, gaxgrpc::CallSettings callSettings = null) =>
            MarkRecommendationFailedAsync(new MarkRecommendationFailedRequest
            {
                RecommendationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                StateMetadata =
                {
                    stateMetadata ?? new scg::Dictionary<string, string>(),
                },
                Etag = gax::GaxPreconditions.CheckNotNullOrEmpty(etag, nameof(etag)),
            }, callSettings);

        /// <summary>
        /// Mark the Recommendation State as Failed. Users can use this method to
        /// indicate to the Recommender API that they have applied the recommendation
        /// themselves, and the operation failed. This stops the recommendation content
        /// from being updated.
        /// 
        /// MarkRecommendationFailed can be applied to recommendations in ACTIVE,
        /// CLAIMED, SUCCEEDED, or FAILED state.
        /// 
        /// Requires the recommender.*.update IAM permission for the specified
        /// recommender.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the recommendation.
        /// </param>
        /// <param name="stateMetadata">
        /// State properties to include with this state. Overwrites any existing
        /// `state_metadata`.
        /// Keys must match the regex /^[a-z0-9][a-z0-9_.-]{0,62}$/.
        /// Values must match the regex /^[a-zA-Z0-9_./-]{0,255}$/.
        /// </param>
        /// <param name="etag">
        /// Required. Fingerprint of the Recommendation. Provides optimistic locking.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Recommendation> MarkRecommendationFailedAsync(RecommendationName name, scg::IDictionary<string, string> stateMetadata, string etag, st::CancellationToken cancellationToken) =>
            MarkRecommendationFailedAsync(name, stateMetadata, etag, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>Recommender client wrapper implementation, for convenient use.</summary>
    public sealed partial class RecommenderClientImpl : RecommenderClient
    {
        private readonly gaxgrpc::ApiCall<ListRecommendationsRequest, ListRecommendationsResponse> _callListRecommendations;

        private readonly gaxgrpc::ApiCall<GetRecommendationRequest, Recommendation> _callGetRecommendation;

        private readonly gaxgrpc::ApiCall<MarkRecommendationClaimedRequest, Recommendation> _callMarkRecommendationClaimed;

        private readonly gaxgrpc::ApiCall<MarkRecommendationSucceededRequest, Recommendation> _callMarkRecommendationSucceeded;

        private readonly gaxgrpc::ApiCall<MarkRecommendationFailedRequest, Recommendation> _callMarkRecommendationFailed;

        /// <summary>
        /// Constructs a client wrapper for the Recommender service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="RecommenderSettings"/> used within this client.</param>
        public RecommenderClientImpl(Recommender.RecommenderClient grpcClient, RecommenderSettings settings)
        {
            GrpcClient = grpcClient;
            RecommenderSettings effectiveSettings = settings ?? RecommenderSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callListRecommendations = clientHelper.BuildApiCall<ListRecommendationsRequest, ListRecommendationsResponse>(grpcClient.ListRecommendationsAsync, grpcClient.ListRecommendations, effectiveSettings.ListRecommendationsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListRecommendations);
            Modify_ListRecommendationsApiCall(ref _callListRecommendations);
            _callGetRecommendation = clientHelper.BuildApiCall<GetRecommendationRequest, Recommendation>(grpcClient.GetRecommendationAsync, grpcClient.GetRecommendation, effectiveSettings.GetRecommendationSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetRecommendation);
            Modify_GetRecommendationApiCall(ref _callGetRecommendation);
            _callMarkRecommendationClaimed = clientHelper.BuildApiCall<MarkRecommendationClaimedRequest, Recommendation>(grpcClient.MarkRecommendationClaimedAsync, grpcClient.MarkRecommendationClaimed, effectiveSettings.MarkRecommendationClaimedSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callMarkRecommendationClaimed);
            Modify_MarkRecommendationClaimedApiCall(ref _callMarkRecommendationClaimed);
            _callMarkRecommendationSucceeded = clientHelper.BuildApiCall<MarkRecommendationSucceededRequest, Recommendation>(grpcClient.MarkRecommendationSucceededAsync, grpcClient.MarkRecommendationSucceeded, effectiveSettings.MarkRecommendationSucceededSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callMarkRecommendationSucceeded);
            Modify_MarkRecommendationSucceededApiCall(ref _callMarkRecommendationSucceeded);
            _callMarkRecommendationFailed = clientHelper.BuildApiCall<MarkRecommendationFailedRequest, Recommendation>(grpcClient.MarkRecommendationFailedAsync, grpcClient.MarkRecommendationFailed, effectiveSettings.MarkRecommendationFailedSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callMarkRecommendationFailed);
            Modify_MarkRecommendationFailedApiCall(ref _callMarkRecommendationFailed);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListRecommendationsApiCall(ref gaxgrpc::ApiCall<ListRecommendationsRequest, ListRecommendationsResponse> call);

        partial void Modify_GetRecommendationApiCall(ref gaxgrpc::ApiCall<GetRecommendationRequest, Recommendation> call);

        partial void Modify_MarkRecommendationClaimedApiCall(ref gaxgrpc::ApiCall<MarkRecommendationClaimedRequest, Recommendation> call);

        partial void Modify_MarkRecommendationSucceededApiCall(ref gaxgrpc::ApiCall<MarkRecommendationSucceededRequest, Recommendation> call);

        partial void Modify_MarkRecommendationFailedApiCall(ref gaxgrpc::ApiCall<MarkRecommendationFailedRequest, Recommendation> call);

        partial void OnConstruction(Recommender.RecommenderClient grpcClient, RecommenderSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC Recommender client</summary>
        public override Recommender.RecommenderClient GrpcClient { get; }

        partial void Modify_ListRecommendationsRequest(ref ListRecommendationsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetRecommendationRequest(ref GetRecommendationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_MarkRecommendationClaimedRequest(ref MarkRecommendationClaimedRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_MarkRecommendationSucceededRequest(ref MarkRecommendationSucceededRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_MarkRecommendationFailedRequest(ref MarkRecommendationFailedRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists recommendations for a Cloud project. Requires the recommender.*.list
        /// IAM permission for the specified recommender.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Recommendation"/> resources.</returns>
        public override gax::PagedEnumerable<ListRecommendationsResponse, Recommendation> ListRecommendations(ListRecommendationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListRecommendationsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListRecommendationsRequest, ListRecommendationsResponse, Recommendation>(_callListRecommendations, request, callSettings);
        }

        /// <summary>
        /// Lists recommendations for a Cloud project. Requires the recommender.*.list
        /// IAM permission for the specified recommender.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Recommendation"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListRecommendationsResponse, Recommendation> ListRecommendationsAsync(ListRecommendationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListRecommendationsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListRecommendationsRequest, ListRecommendationsResponse, Recommendation>(_callListRecommendations, request, callSettings);
        }

        /// <summary>
        /// Gets the requested recommendation. Requires the recommender.*.get
        /// IAM permission for the specified recommender.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Recommendation GetRecommendation(GetRecommendationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetRecommendationRequest(ref request, ref callSettings);
            return _callGetRecommendation.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the requested recommendation. Requires the recommender.*.get
        /// IAM permission for the specified recommender.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Recommendation> GetRecommendationAsync(GetRecommendationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetRecommendationRequest(ref request, ref callSettings);
            return _callGetRecommendation.Async(request, callSettings);
        }

        /// <summary>
        /// Mark the Recommendation State as Claimed. Users can use this method to
        /// indicate to the Recommender API that they are starting to apply the
        /// recommendation themselves. This stops the recommendation content from being
        /// updated.
        /// 
        /// MarkRecommendationClaimed can be applied to recommendations in CLAIMED,
        /// SUCCEEDED, FAILED, or ACTIVE state.
        /// 
        /// Requires the recommender.*.update IAM permission for the specified
        /// recommender.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Recommendation MarkRecommendationClaimed(MarkRecommendationClaimedRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MarkRecommendationClaimedRequest(ref request, ref callSettings);
            return _callMarkRecommendationClaimed.Sync(request, callSettings);
        }

        /// <summary>
        /// Mark the Recommendation State as Claimed. Users can use this method to
        /// indicate to the Recommender API that they are starting to apply the
        /// recommendation themselves. This stops the recommendation content from being
        /// updated.
        /// 
        /// MarkRecommendationClaimed can be applied to recommendations in CLAIMED,
        /// SUCCEEDED, FAILED, or ACTIVE state.
        /// 
        /// Requires the recommender.*.update IAM permission for the specified
        /// recommender.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Recommendation> MarkRecommendationClaimedAsync(MarkRecommendationClaimedRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MarkRecommendationClaimedRequest(ref request, ref callSettings);
            return _callMarkRecommendationClaimed.Async(request, callSettings);
        }

        /// <summary>
        /// Mark the Recommendation State as Succeeded. Users can use this method to
        /// indicate to the Recommender API that they have applied the recommendation
        /// themselves, and the operation was successful. This stops the recommendation
        /// content from being updated.
        /// 
        /// MarkRecommendationSucceeded can be applied to recommendations in ACTIVE,
        /// CLAIMED, SUCCEEDED, or FAILED state.
        /// 
        /// Requires the recommender.*.update IAM permission for the specified
        /// recommender.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Recommendation MarkRecommendationSucceeded(MarkRecommendationSucceededRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MarkRecommendationSucceededRequest(ref request, ref callSettings);
            return _callMarkRecommendationSucceeded.Sync(request, callSettings);
        }

        /// <summary>
        /// Mark the Recommendation State as Succeeded. Users can use this method to
        /// indicate to the Recommender API that they have applied the recommendation
        /// themselves, and the operation was successful. This stops the recommendation
        /// content from being updated.
        /// 
        /// MarkRecommendationSucceeded can be applied to recommendations in ACTIVE,
        /// CLAIMED, SUCCEEDED, or FAILED state.
        /// 
        /// Requires the recommender.*.update IAM permission for the specified
        /// recommender.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Recommendation> MarkRecommendationSucceededAsync(MarkRecommendationSucceededRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MarkRecommendationSucceededRequest(ref request, ref callSettings);
            return _callMarkRecommendationSucceeded.Async(request, callSettings);
        }

        /// <summary>
        /// Mark the Recommendation State as Failed. Users can use this method to
        /// indicate to the Recommender API that they have applied the recommendation
        /// themselves, and the operation failed. This stops the recommendation content
        /// from being updated.
        /// 
        /// MarkRecommendationFailed can be applied to recommendations in ACTIVE,
        /// CLAIMED, SUCCEEDED, or FAILED state.
        /// 
        /// Requires the recommender.*.update IAM permission for the specified
        /// recommender.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Recommendation MarkRecommendationFailed(MarkRecommendationFailedRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MarkRecommendationFailedRequest(ref request, ref callSettings);
            return _callMarkRecommendationFailed.Sync(request, callSettings);
        }

        /// <summary>
        /// Mark the Recommendation State as Failed. Users can use this method to
        /// indicate to the Recommender API that they have applied the recommendation
        /// themselves, and the operation failed. This stops the recommendation content
        /// from being updated.
        /// 
        /// MarkRecommendationFailed can be applied to recommendations in ACTIVE,
        /// CLAIMED, SUCCEEDED, or FAILED state.
        /// 
        /// Requires the recommender.*.update IAM permission for the specified
        /// recommender.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Recommendation> MarkRecommendationFailedAsync(MarkRecommendationFailedRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MarkRecommendationFailedRequest(ref request, ref callSettings);
            return _callMarkRecommendationFailed.Async(request, callSettings);
        }
    }

    public partial class ListRecommendationsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListRecommendationsResponse : gaxgrpc::IPageResponse<Recommendation>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Recommendation> GetEnumerator() => Recommendations.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
