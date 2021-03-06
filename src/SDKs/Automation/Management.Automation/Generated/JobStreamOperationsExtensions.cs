// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Automation
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for JobStreamOperations.
    /// </summary>
    public static partial class JobStreamOperationsExtensions
    {
            /// <summary>
            /// Retrieve the job stream identified by job stream id.
            /// <see href="http://aka.ms/azureautomationsdk/jobstreamoperations" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='automationAccountName'>
            /// The automation account name.
            /// </param>
            /// <param name='jobId'>
            /// The job id.
            /// </param>
            /// <param name='jobStreamId'>
            /// The job stream id.
            /// </param>
            public static JobStream Get(this IJobStreamOperations operations, string resourceGroupName, string automationAccountName, string jobId, string jobStreamId)
            {
                return operations.GetAsync(resourceGroupName, automationAccountName, jobId, jobStreamId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Retrieve the job stream identified by job stream id.
            /// <see href="http://aka.ms/azureautomationsdk/jobstreamoperations" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='automationAccountName'>
            /// The automation account name.
            /// </param>
            /// <param name='jobId'>
            /// The job id.
            /// </param>
            /// <param name='jobStreamId'>
            /// The job stream id.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<JobStream> GetAsync(this IJobStreamOperations operations, string resourceGroupName, string automationAccountName, string jobId, string jobStreamId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, automationAccountName, jobId, jobStreamId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Retrieve a list of jobs streams identified by job id.
            /// <see href="http://aka.ms/azureautomationsdk/jobstreamoperations" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='automationAccountName'>
            /// The automation account name.
            /// </param>
            /// <param name='jobId'>
            /// The job Id.
            /// </param>
            /// <param name='filter'>
            /// The filter to apply on the operation.
            /// </param>
            public static IPage<JobStream> ListByJob(this IJobStreamOperations operations, string resourceGroupName, string automationAccountName, string jobId, string filter = default(string))
            {
                return operations.ListByJobAsync(resourceGroupName, automationAccountName, jobId, filter).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Retrieve a list of jobs streams identified by job id.
            /// <see href="http://aka.ms/azureautomationsdk/jobstreamoperations" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='automationAccountName'>
            /// The automation account name.
            /// </param>
            /// <param name='jobId'>
            /// The job Id.
            /// </param>
            /// <param name='filter'>
            /// The filter to apply on the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<JobStream>> ListByJobAsync(this IJobStreamOperations operations, string resourceGroupName, string automationAccountName, string jobId, string filter = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByJobWithHttpMessagesAsync(resourceGroupName, automationAccountName, jobId, filter, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Retrieve a list of jobs streams identified by job id.
            /// <see href="http://aka.ms/azureautomationsdk/jobstreamoperations" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<JobStream> ListByJobNext(this IJobStreamOperations operations, string nextPageLink)
            {
                return operations.ListByJobNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Retrieve a list of jobs streams identified by job id.
            /// <see href="http://aka.ms/azureautomationsdk/jobstreamoperations" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<JobStream>> ListByJobNextAsync(this IJobStreamOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByJobNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
