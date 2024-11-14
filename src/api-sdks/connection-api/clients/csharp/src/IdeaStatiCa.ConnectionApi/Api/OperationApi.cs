/*
 * Connection Rest API 1.0
 *
 * API for designing steel connections
 *
 * The version of the OpenAPI document: 1.0
 * Contact: info@ideastatica.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using IdeaRS.OpenModel;
using IdeaRS.OpenModel.Connection;
using IdeaStatiCa.Api.Connection.Model;
using IdeaStatiCa.Api.Connection.Model.Connection;
using IdeaStatiCa.Api.Connection.Model.Material;
using IdeaStatiCa.ConnectionApi.Client;
using IdeaStatiCa.ConnectionApi.Model;

namespace IdeaStatiCa.ConnectionApi.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IOperationApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Delete all operations for the connection
        /// </summary>
        /// <exception cref="IdeaStatiCa.ConnectionApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="projectId">The unique identifier of the opened project in the ConnectionRestApi service</param>
        /// <param name="connectionId">Id of the connection to be modified</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        void DeleteOperations(Guid projectId, int connectionId, int operationIndex = 0);

        /// <summary>
        /// Delete all operations for the connection
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IdeaStatiCa.ConnectionApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="projectId">The unique identifier of the opened project in the ConnectionRestApi service</param>
/// <param name="connectionId">Id of the connection to be modified</param>
        /// <param name="requestedType">Requested content type in the response.</param>        
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteOperationsWithHttpInfo(Guid projectId, int connectionId, string requestedType = null, int operationIndex = 0);
        /// <summary>
        /// Get the list of operations for the connection
        /// </summary>
        /// <exception cref="IdeaStatiCa.ConnectionApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="projectId">The unique identifier of the opened project in the ConnectionRestApi service</param>
        /// <param name="connectionId">Id of the requested connection</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>List&lt;ConOperation&gt;</returns>
        List<ConOperation> GetOperations(Guid projectId, int connectionId, int operationIndex = 0);

        /// <summary>
        /// Get the list of operations for the connection
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IdeaStatiCa.ConnectionApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="projectId">The unique identifier of the opened project in the ConnectionRestApi service</param>
/// <param name="connectionId">Id of the requested connection</param>
        /// <param name="requestedType">Requested content type in the response.</param>        
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of List&lt;ConOperation&gt;</returns>
        ApiResponse<List<ConOperation>> GetOperationsWithHttpInfo(Guid projectId, int connectionId, string requestedType = null, int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IOperationApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Delete all operations for the connection
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IdeaStatiCa.ConnectionApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="projectId">The unique identifier of the opened project in the ConnectionRestApi service</param>
        /// <param name="connectionId">Id of the connection to be modified</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteOperationsAsync(Guid projectId, int connectionId, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Delete all operations for the connection
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IdeaStatiCa.ConnectionApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="projectId">The unique identifier of the opened project in the ConnectionRestApi service</param>
        /// <param name="connectionId">Id of the connection to be modified</param>
        /// <param name="requestedType">Requested content type in the response.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteOperationsWithHttpInfoAsync(Guid projectId, int connectionId, string requestedType = null, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Get the list of operations for the connection
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IdeaStatiCa.ConnectionApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="projectId">The unique identifier of the opened project in the ConnectionRestApi service</param>
        /// <param name="connectionId">Id of the requested connection</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;ConOperation&gt;</returns>
        System.Threading.Tasks.Task<List<ConOperation>> GetOperationsAsync(Guid projectId, int connectionId, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Get the list of operations for the connection
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IdeaStatiCa.ConnectionApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="projectId">The unique identifier of the opened project in the ConnectionRestApi service</param>
        /// <param name="connectionId">Id of the requested connection</param>
        /// <param name="requestedType">Requested content type in the response.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;ConOperation&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<ConOperation>>> GetOperationsWithHttpInfoAsync(Guid projectId, int connectionId, string requestedType = null, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IOperationApi : IOperationApiSync, IOperationApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class OperationApi : IOperationApi
    {
        private IdeaStatiCa.ConnectionApi.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="OperationApi"/> class.
        /// </summary>
        /// <returns></returns>
        public OperationApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OperationApi"/> class.
        /// </summary>
        /// <returns></returns>
        public OperationApi(string basePath)
        {
            this.Configuration = IdeaStatiCa.ConnectionApi.Client.Configuration.MergeConfigurations(
                IdeaStatiCa.ConnectionApi.Client.GlobalConfiguration.Instance,
                new IdeaStatiCa.ConnectionApi.Client.Configuration { BasePath = basePath }
            );
            this.Client = new IdeaStatiCa.ConnectionApi.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new IdeaStatiCa.ConnectionApi.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = IdeaStatiCa.ConnectionApi.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OperationApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public OperationApi(IdeaStatiCa.ConnectionApi.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = IdeaStatiCa.ConnectionApi.Client.Configuration.MergeConfigurations(
                IdeaStatiCa.ConnectionApi.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new IdeaStatiCa.ConnectionApi.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new IdeaStatiCa.ConnectionApi.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = IdeaStatiCa.ConnectionApi.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OperationApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public OperationApi(IdeaStatiCa.ConnectionApi.Client.ISynchronousClient client, IdeaStatiCa.ConnectionApi.Client.IAsynchronousClient asyncClient, IdeaStatiCa.ConnectionApi.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = IdeaStatiCa.ConnectionApi.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public IdeaStatiCa.ConnectionApi.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public IdeaStatiCa.ConnectionApi.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public IdeaStatiCa.ConnectionApi.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public IdeaStatiCa.ConnectionApi.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Delete all operations for the connection 
        /// </summary>
        /// <exception cref="IdeaStatiCa.ConnectionApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="projectId">The unique identifier of the opened project in the ConnectionRestApi service</param>
        /// <param name="connectionId">Id of the connection to be modified</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        public void DeleteOperations(Guid projectId, int connectionId, int operationIndex = 0)
        {
            DeleteOperationsWithHttpInfo(projectId, connectionId);
        }

        /// <summary>
        /// Delete all operations for the connection 
        /// </summary>
        /// <exception cref="IdeaStatiCa.ConnectionApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="projectId">The unique identifier of the opened project in the ConnectionRestApi service</param>
/// <param name="connectionId">Id of the connection to be modified</param>
        /// <param name="requestedType">Requested content type in the response.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public IdeaStatiCa.ConnectionApi.Client.ApiResponse<Object> DeleteOperationsWithHttpInfo(Guid projectId, int connectionId, string requestedType = null, int operationIndex = 0)
        {
            IdeaStatiCa.ConnectionApi.Client.RequestOptions localVarRequestOptions = new IdeaStatiCa.ConnectionApi.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
            };

            var localVarContentType = IdeaStatiCa.ConnectionApi.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            string localVarAccept = requestedType;

            if(string.IsNullOrEmpty(localVarAccept))
            {
                localVarAccept = IdeaStatiCa.ConnectionApi.Client.ClientUtils.SelectHeaderAccept(_accepts);
                if (localVarAccept != null)
                {
                    localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
                }
            }

            localVarRequestOptions.PathParameters.Add("projectId", IdeaStatiCa.ConnectionApi.Client.ClientUtils.ParameterToString(projectId)); // path parameter
            localVarRequestOptions.PathParameters.Add("connectionId", IdeaStatiCa.ConnectionApi.Client.ClientUtils.ParameterToString(connectionId)); // path parameter

            localVarRequestOptions.Operation = "OperationApi.DeleteOperations";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = this.Client.Delete<Object>("/api/1/projects/{projectId}/connections/{connectionId}/operations", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeleteOperations", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Delete all operations for the connection 
        /// </summary>
        /// <exception cref="IdeaStatiCa.ConnectionApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="projectId">The unique identifier of the opened project in the ConnectionRestApi service</param>
        /// <param name="connectionId">Id of the connection to be modified</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteOperationsAsync(Guid projectId, int connectionId, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            await DeleteOperationsWithHttpInfoAsync(projectId, connectionId, null, operationIndex, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Delete all operations for the connection 
        /// </summary>
        /// <exception cref="IdeaStatiCa.ConnectionApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="projectId">The unique identifier of the opened project in the ConnectionRestApi service</param>
        /// <param name="connectionId">Id of the connection to be modified</param>
        /// <param name="requestedType">Requested content type in the response.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<IdeaStatiCa.ConnectionApi.Client.ApiResponse<Object>> DeleteOperationsWithHttpInfoAsync(Guid projectId, int connectionId, string requestedType = null, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            IdeaStatiCa.ConnectionApi.Client.RequestOptions localVarRequestOptions = new IdeaStatiCa.ConnectionApi.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
            };

            var localVarContentType = IdeaStatiCa.ConnectionApi.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            string localVarAccept = requestedType;
            if(string.IsNullOrEmpty(localVarAccept))
            {
                localVarAccept = IdeaStatiCa.ConnectionApi.Client.ClientUtils.SelectHeaderAccept(_accepts);
            }

            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("projectId", IdeaStatiCa.ConnectionApi.Client.ClientUtils.ParameterToString(projectId)); // path parameter
            localVarRequestOptions.PathParameters.Add("connectionId", IdeaStatiCa.ConnectionApi.Client.ClientUtils.ParameterToString(connectionId)); // path parameter

            localVarRequestOptions.Operation = "OperationApi.DeleteOperations";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.DeleteAsync<Object>("/api/1/projects/{projectId}/connections/{connectionId}/operations", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeleteOperations", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the list of operations for the connection 
        /// </summary>
        /// <exception cref="IdeaStatiCa.ConnectionApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="projectId">The unique identifier of the opened project in the ConnectionRestApi service</param>
        /// <param name="connectionId">Id of the requested connection</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>List&lt;ConOperation&gt;</returns>
        public List<ConOperation> GetOperations(Guid projectId, int connectionId, int operationIndex = 0)
        {
            IdeaStatiCa.ConnectionApi.Client.ApiResponse<List<ConOperation>> localVarResponse = GetOperationsWithHttpInfo(projectId, connectionId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the list of operations for the connection 
        /// </summary>
        /// <exception cref="IdeaStatiCa.ConnectionApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="projectId">The unique identifier of the opened project in the ConnectionRestApi service</param>
/// <param name="connectionId">Id of the requested connection</param>
        /// <param name="requestedType">Requested content type in the response.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of List&lt;ConOperation&gt;</returns>
        public IdeaStatiCa.ConnectionApi.Client.ApiResponse<List<ConOperation>> GetOperationsWithHttpInfo(Guid projectId, int connectionId, string requestedType = null, int operationIndex = 0)
        {
            IdeaStatiCa.ConnectionApi.Client.RequestOptions localVarRequestOptions = new IdeaStatiCa.ConnectionApi.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = IdeaStatiCa.ConnectionApi.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            string localVarAccept = requestedType;

            if(string.IsNullOrEmpty(localVarAccept))
            {
                localVarAccept = IdeaStatiCa.ConnectionApi.Client.ClientUtils.SelectHeaderAccept(_accepts);
                if (localVarAccept != null)
                {
                    localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
                }
            }

            localVarRequestOptions.PathParameters.Add("projectId", IdeaStatiCa.ConnectionApi.Client.ClientUtils.ParameterToString(projectId)); // path parameter
            localVarRequestOptions.PathParameters.Add("connectionId", IdeaStatiCa.ConnectionApi.Client.ClientUtils.ParameterToString(connectionId)); // path parameter

            localVarRequestOptions.Operation = "OperationApi.GetOperations";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = this.Client.Get<List<ConOperation>>("/api/1/projects/{projectId}/connections/{connectionId}/operations", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetOperations", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the list of operations for the connection 
        /// </summary>
        /// <exception cref="IdeaStatiCa.ConnectionApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="projectId">The unique identifier of the opened project in the ConnectionRestApi service</param>
        /// <param name="connectionId">Id of the requested connection</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;ConOperation&gt;</returns>
        public async System.Threading.Tasks.Task<List<ConOperation>> GetOperationsAsync(Guid projectId, int connectionId, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            IdeaStatiCa.ConnectionApi.Client.ApiResponse<List<ConOperation>> localVarResponse = await GetOperationsWithHttpInfoAsync(projectId, connectionId, null, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the list of operations for the connection 
        /// </summary>
        /// <exception cref="IdeaStatiCa.ConnectionApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="projectId">The unique identifier of the opened project in the ConnectionRestApi service</param>
        /// <param name="connectionId">Id of the requested connection</param>
        /// <param name="requestedType">Requested content type in the response.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;ConOperation&gt;)</returns>
        public async System.Threading.Tasks.Task<IdeaStatiCa.ConnectionApi.Client.ApiResponse<List<ConOperation>>> GetOperationsWithHttpInfoAsync(Guid projectId, int connectionId, string requestedType = null, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            IdeaStatiCa.ConnectionApi.Client.RequestOptions localVarRequestOptions = new IdeaStatiCa.ConnectionApi.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = IdeaStatiCa.ConnectionApi.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            string localVarAccept = requestedType;
            if(string.IsNullOrEmpty(localVarAccept))
            {
                localVarAccept = IdeaStatiCa.ConnectionApi.Client.ClientUtils.SelectHeaderAccept(_accepts);
            }

            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("projectId", IdeaStatiCa.ConnectionApi.Client.ClientUtils.ParameterToString(projectId)); // path parameter
            localVarRequestOptions.PathParameters.Add("connectionId", IdeaStatiCa.ConnectionApi.Client.ClientUtils.ParameterToString(connectionId)); // path parameter

            localVarRequestOptions.Operation = "OperationApi.GetOperations";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<List<ConOperation>>("/api/1/projects/{projectId}/connections/{connectionId}/operations", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetOperations", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
