using System;
using System.Threading;
using System.Threading.Tasks;
using Elasticsearch.Net.Specification.SnapshotApi;

//This file is automatically generated from https://github.com/elastic/elasticsearch/tree/master/rest-api-spec
// ReSharper disable once CheckNamespace
namespace Nest.Specification.SnapshotApi
{
	///<summary>
	/// Logically groups all Snapshot API's together so that they may be discovered more naturally.
	/// <para>Not intended to be instantiated directly please defer to the <see cref = "IElasticClient.Snapshot"/> property
	/// on <see cref = "IElasticClient"/>.
	///</para>
	///</summary>
	public class SnapshotNamespace : NamespacedClientProxy
	{
		internal SnapshotNamespace(ElasticClient client): base(client)
		{
		}

		///<inheritdoc cref = "ISnapshotRequest"/>
		public SnapshotResponse Snapshot(Name repository, Name snapshot, Func<SnapshotDescriptor, ISnapshotRequest> selector = null) => Snapshot(selector.InvokeOrDefault(new SnapshotDescriptor(repository: repository, snapshot: snapshot)));
		///<inheritdoc cref = "ISnapshotRequest"/>
		public Task<SnapshotResponse> SnapshotAsync(Name repository, Name snapshot, Func<SnapshotDescriptor, ISnapshotRequest> selector = null, CancellationToken ct = default) => SnapshotAsync(selector.InvokeOrDefault(new SnapshotDescriptor(repository: repository, snapshot: snapshot)), ct);
		///<inheritdoc cref = "ISnapshotRequest"/>
		public SnapshotResponse Snapshot(ISnapshotRequest request) => DoRequest<ISnapshotRequest, SnapshotResponse>(request, request.RequestParameters);
		///<inheritdoc cref = "ISnapshotRequest"/>
		public Task<SnapshotResponse> SnapshotAsync(ISnapshotRequest request, CancellationToken ct = default) => DoRequestAsync<ISnapshotRequest, SnapshotResponse>(request, request.RequestParameters, ct);
		///<inheritdoc cref = "ICreateRepositoryRequest"/>
		public CreateRepositoryResponse CreateRepository(Name repository, Func<CreateRepositoryDescriptor, ICreateRepositoryRequest> selector) => CreateRepository(selector.InvokeOrDefault(new CreateRepositoryDescriptor(repository: repository)));
		///<inheritdoc cref = "ICreateRepositoryRequest"/>
		public Task<CreateRepositoryResponse> CreateRepositoryAsync(Name repository, Func<CreateRepositoryDescriptor, ICreateRepositoryRequest> selector, CancellationToken ct = default) => CreateRepositoryAsync(selector.InvokeOrDefault(new CreateRepositoryDescriptor(repository: repository)), ct);
		///<inheritdoc cref = "ICreateRepositoryRequest"/>
		public CreateRepositoryResponse CreateRepository(ICreateRepositoryRequest request) => DoRequest<ICreateRepositoryRequest, CreateRepositoryResponse>(request, request.RequestParameters);
		///<inheritdoc cref = "ICreateRepositoryRequest"/>
		public Task<CreateRepositoryResponse> CreateRepositoryAsync(ICreateRepositoryRequest request, CancellationToken ct = default) => DoRequestAsync<ICreateRepositoryRequest, CreateRepositoryResponse>(request, request.RequestParameters, ct);
		///<inheritdoc cref = "IDeleteSnapshotRequest"/>
		public DeleteSnapshotResponse DeleteSnapshot(Name repository, Name snapshot, Func<DeleteSnapshotDescriptor, IDeleteSnapshotRequest> selector = null) => DeleteSnapshot(selector.InvokeOrDefault(new DeleteSnapshotDescriptor(repository: repository, snapshot: snapshot)));
		///<inheritdoc cref = "IDeleteSnapshotRequest"/>
		public Task<DeleteSnapshotResponse> DeleteSnapshotAsync(Name repository, Name snapshot, Func<DeleteSnapshotDescriptor, IDeleteSnapshotRequest> selector = null, CancellationToken ct = default) => DeleteSnapshotAsync(selector.InvokeOrDefault(new DeleteSnapshotDescriptor(repository: repository, snapshot: snapshot)), ct);
		///<inheritdoc cref = "IDeleteSnapshotRequest"/>
		public DeleteSnapshotResponse DeleteSnapshot(IDeleteSnapshotRequest request) => DoRequest<IDeleteSnapshotRequest, DeleteSnapshotResponse>(request, request.RequestParameters);
		///<inheritdoc cref = "IDeleteSnapshotRequest"/>
		public Task<DeleteSnapshotResponse> DeleteSnapshotAsync(IDeleteSnapshotRequest request, CancellationToken ct = default) => DoRequestAsync<IDeleteSnapshotRequest, DeleteSnapshotResponse>(request, request.RequestParameters, ct);
		///<inheritdoc cref = "IDeleteRepositoryRequest"/>
		public DeleteRepositoryResponse DeleteRepository(Names repository, Func<DeleteRepositoryDescriptor, IDeleteRepositoryRequest> selector = null) => DeleteRepository(selector.InvokeOrDefault(new DeleteRepositoryDescriptor(repository: repository)));
		///<inheritdoc cref = "IDeleteRepositoryRequest"/>
		public Task<DeleteRepositoryResponse> DeleteRepositoryAsync(Names repository, Func<DeleteRepositoryDescriptor, IDeleteRepositoryRequest> selector = null, CancellationToken ct = default) => DeleteRepositoryAsync(selector.InvokeOrDefault(new DeleteRepositoryDescriptor(repository: repository)), ct);
		///<inheritdoc cref = "IDeleteRepositoryRequest"/>
		public DeleteRepositoryResponse DeleteRepository(IDeleteRepositoryRequest request) => DoRequest<IDeleteRepositoryRequest, DeleteRepositoryResponse>(request, request.RequestParameters);
		///<inheritdoc cref = "IDeleteRepositoryRequest"/>
		public Task<DeleteRepositoryResponse> DeleteRepositoryAsync(IDeleteRepositoryRequest request, CancellationToken ct = default) => DoRequestAsync<IDeleteRepositoryRequest, DeleteRepositoryResponse>(request, request.RequestParameters, ct);
		///<inheritdoc cref = "IGetSnapshotRequest"/>
		public GetSnapshotResponse GetSnapshot(Name repository, Names snapshot, Func<GetSnapshotDescriptor, IGetSnapshotRequest> selector = null) => GetSnapshot(selector.InvokeOrDefault(new GetSnapshotDescriptor(repository: repository, snapshot: snapshot)));
		///<inheritdoc cref = "IGetSnapshotRequest"/>
		public Task<GetSnapshotResponse> GetSnapshotAsync(Name repository, Names snapshot, Func<GetSnapshotDescriptor, IGetSnapshotRequest> selector = null, CancellationToken ct = default) => GetSnapshotAsync(selector.InvokeOrDefault(new GetSnapshotDescriptor(repository: repository, snapshot: snapshot)), ct);
		///<inheritdoc cref = "IGetSnapshotRequest"/>
		public GetSnapshotResponse GetSnapshot(IGetSnapshotRequest request) => DoRequest<IGetSnapshotRequest, GetSnapshotResponse>(request, request.RequestParameters);
		///<inheritdoc cref = "IGetSnapshotRequest"/>
		public Task<GetSnapshotResponse> GetSnapshotAsync(IGetSnapshotRequest request, CancellationToken ct = default) => DoRequestAsync<IGetSnapshotRequest, GetSnapshotResponse>(request, request.RequestParameters, ct);
		///<inheritdoc cref = "IGetRepositoryRequest"/>
		public GetRepositoryResponse GetRepository(Func<GetRepositoryDescriptor, IGetRepositoryRequest> selector = null) => GetRepository(selector.InvokeOrDefault(new GetRepositoryDescriptor()));
		///<inheritdoc cref = "IGetRepositoryRequest"/>
		public Task<GetRepositoryResponse> GetRepositoryAsync(Func<GetRepositoryDescriptor, IGetRepositoryRequest> selector = null, CancellationToken ct = default) => GetRepositoryAsync(selector.InvokeOrDefault(new GetRepositoryDescriptor()), ct);
		///<inheritdoc cref = "IGetRepositoryRequest"/>
		public GetRepositoryResponse GetRepository(IGetRepositoryRequest request) => DoRequest<IGetRepositoryRequest, GetRepositoryResponse>(request, request.RequestParameters);
		///<inheritdoc cref = "IGetRepositoryRequest"/>
		public Task<GetRepositoryResponse> GetRepositoryAsync(IGetRepositoryRequest request, CancellationToken ct = default) => DoRequestAsync<IGetRepositoryRequest, GetRepositoryResponse>(request, request.RequestParameters, ct);
		///<inheritdoc cref = "IRestoreRequest"/>
		public RestoreResponse Restore(Name repository, Name snapshot, Func<RestoreDescriptor, IRestoreRequest> selector = null) => Restore(selector.InvokeOrDefault(new RestoreDescriptor(repository: repository, snapshot: snapshot)));
		///<inheritdoc cref = "IRestoreRequest"/>
		public Task<RestoreResponse> RestoreAsync(Name repository, Name snapshot, Func<RestoreDescriptor, IRestoreRequest> selector = null, CancellationToken ct = default) => RestoreAsync(selector.InvokeOrDefault(new RestoreDescriptor(repository: repository, snapshot: snapshot)), ct);
		///<inheritdoc cref = "IRestoreRequest"/>
		public RestoreResponse Restore(IRestoreRequest request) => DoRequest<IRestoreRequest, RestoreResponse>(request, request.RequestParameters);
		///<inheritdoc cref = "IRestoreRequest"/>
		public Task<RestoreResponse> RestoreAsync(IRestoreRequest request, CancellationToken ct = default) => DoRequestAsync<IRestoreRequest, RestoreResponse>(request, request.RequestParameters, ct);
		///<inheritdoc cref = "ISnapshotStatusRequest"/>
		public SnapshotStatusResponse Status(Func<SnapshotStatusDescriptor, ISnapshotStatusRequest> selector = null) => Status(selector.InvokeOrDefault(new SnapshotStatusDescriptor()));
		///<inheritdoc cref = "ISnapshotStatusRequest"/>
		public Task<SnapshotStatusResponse> StatusAsync(Func<SnapshotStatusDescriptor, ISnapshotStatusRequest> selector = null, CancellationToken ct = default) => StatusAsync(selector.InvokeOrDefault(new SnapshotStatusDescriptor()), ct);
		///<inheritdoc cref = "ISnapshotStatusRequest"/>
		public SnapshotStatusResponse Status(ISnapshotStatusRequest request) => DoRequest<ISnapshotStatusRequest, SnapshotStatusResponse>(request, request.RequestParameters);
		///<inheritdoc cref = "ISnapshotStatusRequest"/>
		public Task<SnapshotStatusResponse> StatusAsync(ISnapshotStatusRequest request, CancellationToken ct = default) => DoRequestAsync<ISnapshotStatusRequest, SnapshotStatusResponse>(request, request.RequestParameters, ct);
		///<inheritdoc cref = "IVerifyRepositoryRequest"/>
		public VerifyRepositoryResponse VerifyRepository(Name repository, Func<VerifyRepositoryDescriptor, IVerifyRepositoryRequest> selector = null) => VerifyRepository(selector.InvokeOrDefault(new VerifyRepositoryDescriptor(repository: repository)));
		///<inheritdoc cref = "IVerifyRepositoryRequest"/>
		public Task<VerifyRepositoryResponse> VerifyRepositoryAsync(Name repository, Func<VerifyRepositoryDescriptor, IVerifyRepositoryRequest> selector = null, CancellationToken ct = default) => VerifyRepositoryAsync(selector.InvokeOrDefault(new VerifyRepositoryDescriptor(repository: repository)), ct);
		///<inheritdoc cref = "IVerifyRepositoryRequest"/>
		public VerifyRepositoryResponse VerifyRepository(IVerifyRepositoryRequest request) => DoRequest<IVerifyRepositoryRequest, VerifyRepositoryResponse>(request, request.RequestParameters);
		///<inheritdoc cref = "IVerifyRepositoryRequest"/>
		public Task<VerifyRepositoryResponse> VerifyRepositoryAsync(IVerifyRepositoryRequest request, CancellationToken ct = default) => DoRequestAsync<IVerifyRepositoryRequest, VerifyRepositoryResponse>(request, request.RequestParameters, ct);
	}
}