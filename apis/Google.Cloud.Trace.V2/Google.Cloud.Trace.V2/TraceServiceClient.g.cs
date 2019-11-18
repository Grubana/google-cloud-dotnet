// Copyright 2019 Google LLC
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
using gagr = Google.Api.Gax.ResourceNames;
using proto = Google.Protobuf;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using sys = System;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using sysnet = System.Net;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Cloud.Trace.V2
{
    /// <summary>Settings for <see cref="TraceServiceClient"/> instances.</summary>
    public sealed partial class TraceServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="TraceServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="TraceServiceSettings"/>.</returns>
        public static TraceServiceSettings GetDefault() => new TraceServiceSettings();

        /// <summary>Constructs a new <see cref="TraceServiceSettings"/> object with default settings.</summary>
        public TraceServiceSettings()
        {
        }

        private TraceServiceSettings(TraceServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            BatchWriteSpansSettings = existing.BatchWriteSpansSettings;
            CreateSpanSettings = existing.CreateSpanSettings;
            OnCopy(existing);
        }

        partial void OnCopy(TraceServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TraceServiceClient.BatchWriteSpans</c> and <c>TraceServiceClient.BatchWriteSpansAsync</c>.
        /// </summary>
        /// <remarks>By default, retry will not be attempted.</remarks>
        public gaxgrpc::CallSettings BatchWriteSpansSettings { get; set; }

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TraceServiceClient.CreateSpan</c> and <c>TraceServiceClient.CreateSpanAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.20000004768372</description></item>
        /// <item><description>Retry maximum delay: 1000 milliseconds.</description></item>
        /// <item><description>Initial timeout: 120000 milliseconds.</description></item>
        /// <item><description>Timeout multiplier: 1</description></item>
        /// <item><description>Timeout maximum delay: 120000 milliseconds.</description></item>
        /// <item><description>Total timeout: 120 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateSpanSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(retryBackoff: new gaxgrpc::BackoffSettings(delay: sys::TimeSpan.FromMilliseconds(100), maxDelay: sys::TimeSpan.FromMilliseconds(1000), delayMultiplier: 1.2000000476837158), timeoutBackoff: new gaxgrpc::BackoffSettings(delay: sys::TimeSpan.FromMilliseconds(120000), maxDelay: sys::TimeSpan.FromMilliseconds(120000), delayMultiplier: 1), totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(120000)), retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded))));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="TraceServiceSettings"/> object.</returns>
        public TraceServiceSettings Clone() => new TraceServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="TraceServiceClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class TraceServiceClientBuilder : gaxgrpc::ClientBuilderBase<TraceServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public TraceServiceSettings Settings { get; set; }

        /// <inheritdoc/>
        public override TraceServiceClient Build()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return TraceServiceClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc/>
        public override async stt::Task<TraceServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return TraceServiceClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc/>
        protected override gaxgrpc::ServiceEndpoint GetDefaultEndpoint() => TraceServiceClient.DefaultEndpoint;

        /// <inheritdoc/>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => TraceServiceClient.DefaultScopes;

        /// <inheritdoc/>
        protected override gaxgrpc::ChannelPool GetChannelPool() => TraceServiceClient.ChannelPool;
    }

    /// <summary>TraceService client wrapper, for convenient use.</summary>
    public abstract partial class TraceServiceClient
    {
        /// <summary>
        /// The default endpoint for the TraceService service, which is a host of "cloudtrace.googleapis.com" and a port
        /// of 443.
        /// </summary>
        public static gaxgrpc::ServiceEndpoint DefaultEndpoint { get; } = new gaxgrpc::ServiceEndpoint("cloudtrace.googleapis.com", 443);

        /// <summary>The default TraceService scopes.</summary>
        /// <remarks>
        /// The default TraceService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// <item><description>https://www.googleapis.com/auth/trace.append</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/trace.append",
        });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="TraceServiceClient"/>, applying defaults for all unspecified settings, 
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
        /// <param name="settings">Optional <see cref="TraceServiceSettings"/>.</param>
        /// <returns>The task representing the created <see cref="TraceServiceClient"/>.</returns>
        public static async stt::Task<TraceServiceClient> CreateAsync(gaxgrpc::ServiceEndpoint endpoint = null, TraceServiceSettings settings = null)
        {
            grpccore::Channel channel = await ChannelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="TraceServiceClient"/>, applying defaults for all unspecified settings, 
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
        /// <param name="settings">Optional <see cref="TraceServiceSettings"/>.</param>
        /// <returns>The created <see cref="TraceServiceClient"/>.</returns>
        public static TraceServiceClient Create(gaxgrpc::ServiceEndpoint endpoint = null, TraceServiceSettings settings = null)
        {
            grpccore::Channel channel = ChannelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="TraceServiceClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="grpccore::Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="TraceServiceSettings"/>.</param>
        /// <returns>The created <see cref="TraceServiceClient"/>.</returns>
        public static TraceServiceClient Create(grpccore::Channel channel, TraceServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(channel, nameof(channel));
            return Create(new grpccore::DefaultCallInvoker(channel), settings);
        }

        /// <summary>
        /// Creates a <see cref="TraceServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="TraceServiceSettings"/>.</param>
        /// <returns>The created <see cref="TraceServiceClient"/>.</returns>
        public static TraceServiceClient Create(grpccore::CallInvoker callInvoker, TraceServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            TraceService.TraceServiceClient grpcClient = new TraceService.TraceServiceClient(callInvoker);
            return new TraceServiceClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by
        /// <see cref="Create(grpccore::CallInvoker,TraceServiceSettings)"/> and
        /// <see cref="CreateAsync(gaxgrpc::ServiceEndpoint,TraceServiceSettings)"/>. Channels which weren't
        /// automatically created are not affected.
        /// </summary>
        /// <remarks>
        /// After calling this method, further calls to <see cref="Create(grpccore::CallInvoker,TraceServiceSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint,TraceServiceSettings)"/> will create new channels, which
        /// could in turn be shut down by another call to this method.
        /// </remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => ChannelPool.ShutdownChannelsAsync();

        /// <summary>The underlying gRPC TraceService client</summary>
        public virtual TraceService.TraceServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Sends new spans to new or existing traces. You cannot update
        /// existing spans.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void BatchWriteSpans(BatchWriteSpansRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sends new spans to new or existing traces. You cannot update
        /// existing spans.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task BatchWriteSpansAsync(BatchWriteSpansRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sends new spans to new or existing traces. You cannot update
        /// existing spans.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task BatchWriteSpansAsync(BatchWriteSpansRequest request, st::CancellationToken cancellationToken) =>
            BatchWriteSpansAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sends new spans to new or existing traces. You cannot update
        /// existing spans.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the project where the spans belong. The format is
        /// `projects/[PROJECT_ID]`.
        /// </param>
        /// <param name="spans">
        /// Required. A list of new spans. The span names must not match existing
        /// spans, or the results are undefined.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void BatchWriteSpans(string name, scg::IEnumerable<Span> spans, gaxgrpc::CallSettings callSettings = null) =>
            BatchWriteSpans(new BatchWriteSpansRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                Spans =
                {
                    gax::GaxPreconditions.CheckNotNull(spans, nameof(spans)),
                },
            }, callSettings);

        /// <summary>
        /// Sends new spans to new or existing traces. You cannot update
        /// existing spans.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the project where the spans belong. The format is
        /// `projects/[PROJECT_ID]`.
        /// </param>
        /// <param name="spans">
        /// Required. A list of new spans. The span names must not match existing
        /// spans, or the results are undefined.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task BatchWriteSpansAsync(string name, scg::IEnumerable<Span> spans, gaxgrpc::CallSettings callSettings = null) =>
            BatchWriteSpansAsync(new BatchWriteSpansRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                Spans =
                {
                    gax::GaxPreconditions.CheckNotNull(spans, nameof(spans)),
                },
            }, callSettings);

        /// <summary>
        /// Sends new spans to new or existing traces. You cannot update
        /// existing spans.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the project where the spans belong. The format is
        /// `projects/[PROJECT_ID]`.
        /// </param>
        /// <param name="spans">
        /// Required. A list of new spans. The span names must not match existing
        /// spans, or the results are undefined.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task BatchWriteSpansAsync(string name, scg::IEnumerable<Span> spans, st::CancellationToken cancellationToken) =>
            BatchWriteSpansAsync(name, spans, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sends new spans to new or existing traces. You cannot update
        /// existing spans.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the project where the spans belong. The format is
        /// `projects/[PROJECT_ID]`.
        /// </param>
        /// <param name="spans">
        /// Required. A list of new spans. The span names must not match existing
        /// spans, or the results are undefined.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void BatchWriteSpans(gagr::ProjectName name, scg::IEnumerable<Span> spans, gaxgrpc::CallSettings callSettings = null) =>
            BatchWriteSpans(new BatchWriteSpansRequest
            {
                ProjectName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                Spans =
                {
                    gax::GaxPreconditions.CheckNotNull(spans, nameof(spans)),
                },
            }, callSettings);

        /// <summary>
        /// Sends new spans to new or existing traces. You cannot update
        /// existing spans.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the project where the spans belong. The format is
        /// `projects/[PROJECT_ID]`.
        /// </param>
        /// <param name="spans">
        /// Required. A list of new spans. The span names must not match existing
        /// spans, or the results are undefined.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task BatchWriteSpansAsync(gagr::ProjectName name, scg::IEnumerable<Span> spans, gaxgrpc::CallSettings callSettings = null) =>
            BatchWriteSpansAsync(new BatchWriteSpansRequest
            {
                ProjectName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                Spans =
                {
                    gax::GaxPreconditions.CheckNotNull(spans, nameof(spans)),
                },
            }, callSettings);

        /// <summary>
        /// Sends new spans to new or existing traces. You cannot update
        /// existing spans.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the project where the spans belong. The format is
        /// `projects/[PROJECT_ID]`.
        /// </param>
        /// <param name="spans">
        /// Required. A list of new spans. The span names must not match existing
        /// spans, or the results are undefined.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task BatchWriteSpansAsync(gagr::ProjectName name, scg::IEnumerable<Span> spans, st::CancellationToken cancellationToken) =>
            BatchWriteSpansAsync(name, spans, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new span.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Span CreateSpan(Span request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new span.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Span> CreateSpanAsync(Span request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new span.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Span> CreateSpanAsync(Span request, st::CancellationToken cancellationToken) =>
            CreateSpanAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>TraceService client wrapper implementation, for convenient use.</summary>
    public sealed partial class TraceServiceClientImpl : TraceServiceClient
    {
        private readonly gaxgrpc::ApiCall<BatchWriteSpansRequest, wkt::Empty> _callBatchWriteSpans;

        private readonly gaxgrpc::ApiCall<Span, Span> _callCreateSpan;

        /// <summary>
        /// Constructs a client wrapper for the TraceService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="TraceServiceSettings"/> used within this client.</param>
        public TraceServiceClientImpl(TraceService.TraceServiceClient grpcClient, TraceServiceSettings settings)
        {
            GrpcClient = grpcClient;
            TraceServiceSettings effectiveSettings = settings ?? TraceServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callBatchWriteSpans = clientHelper.BuildApiCall<BatchWriteSpansRequest, wkt::Empty>(grpcClient.BatchWriteSpansAsync, grpcClient.BatchWriteSpans, effectiveSettings.BatchWriteSpansSettings).WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"name={(sysnet::WebUtility.UrlEncode(request.Name))}"));
            Modify_ApiCall(ref _callBatchWriteSpans);
            Modify_BatchWriteSpansApiCall(ref _callBatchWriteSpans);
            _callCreateSpan = clientHelper.BuildApiCall<Span, Span>(grpcClient.CreateSpanAsync, grpcClient.CreateSpan, effectiveSettings.CreateSpanSettings).WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"name={(sysnet::WebUtility.UrlEncode(request.Name))}"));
            Modify_ApiCall(ref _callCreateSpan);
            Modify_CreateSpanApiCall(ref _callCreateSpan);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_BatchWriteSpansApiCall(ref gaxgrpc::ApiCall<BatchWriteSpansRequest, wkt::Empty> call);

        partial void Modify_CreateSpanApiCall(ref gaxgrpc::ApiCall<Span, Span> call);

        partial void OnConstruction(TraceService.TraceServiceClient grpcClient, TraceServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC TraceService client</summary>
        public override TraceService.TraceServiceClient GrpcClient { get; }

        partial void Modify_BatchWriteSpansRequest(ref BatchWriteSpansRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_Span(ref Span request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Sends new spans to new or existing traces. You cannot update
        /// existing spans.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void BatchWriteSpans(BatchWriteSpansRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchWriteSpansRequest(ref request, ref callSettings);
            _callBatchWriteSpans.Sync(request, callSettings);
        }

        /// <summary>
        /// Sends new spans to new or existing traces. You cannot update
        /// existing spans.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task BatchWriteSpansAsync(BatchWriteSpansRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchWriteSpansRequest(ref request, ref callSettings);
            return _callBatchWriteSpans.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a new span.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Span CreateSpan(Span request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_Span(ref request, ref callSettings);
            return _callCreateSpan.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a new span.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Span> CreateSpanAsync(Span request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_Span(ref request, ref callSettings);
            return _callCreateSpan.Async(request, callSettings);
        }
    }
}
