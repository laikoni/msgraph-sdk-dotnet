// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IWorkbookChartLineFormatRequest.
    /// </summary>
    public partial interface IWorkbookChartLineFormatRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified WorkbookChartLineFormat using PUT.
        /// </summary>
        /// <param name="workbookChartLineFormatToCreate">The WorkbookChartLineFormat to create.</param>
        /// <returns>The created WorkbookChartLineFormat.</returns>
        System.Threading.Tasks.Task<WorkbookChartLineFormat> CreateAsync(WorkbookChartLineFormat workbookChartLineFormatToCreate);        /// <summary>
        /// Creates the specified WorkbookChartLineFormat using PUT.
        /// </summary>
        /// <param name="workbookChartLineFormatToCreate">The WorkbookChartLineFormat to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created WorkbookChartLineFormat.</returns>
        System.Threading.Tasks.Task<WorkbookChartLineFormat> CreateAsync(WorkbookChartLineFormat workbookChartLineFormatToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified WorkbookChartLineFormat.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified WorkbookChartLineFormat.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified WorkbookChartLineFormat.
        /// </summary>
        /// <returns>The WorkbookChartLineFormat.</returns>
        System.Threading.Tasks.Task<WorkbookChartLineFormat> GetAsync();

        /// <summary>
        /// Gets the specified WorkbookChartLineFormat.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The WorkbookChartLineFormat.</returns>
        System.Threading.Tasks.Task<WorkbookChartLineFormat> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified WorkbookChartLineFormat using PATCH.
        /// </summary>
        /// <param name="workbookChartLineFormatToUpdate">The WorkbookChartLineFormat to update.</param>
        /// <returns>The updated WorkbookChartLineFormat.</returns>
        System.Threading.Tasks.Task<WorkbookChartLineFormat> UpdateAsync(WorkbookChartLineFormat workbookChartLineFormatToUpdate);

        /// <summary>
        /// Updates the specified WorkbookChartLineFormat using PATCH.
        /// </summary>
        /// <param name="workbookChartLineFormatToUpdate">The WorkbookChartLineFormat to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated WorkbookChartLineFormat.</returns>
        System.Threading.Tasks.Task<WorkbookChartLineFormat> UpdateAsync(WorkbookChartLineFormat workbookChartLineFormatToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookChartLineFormatRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookChartLineFormatRequest Expand(Expression<Func<WorkbookChartLineFormat, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookChartLineFormatRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookChartLineFormatRequest Select(Expression<Func<WorkbookChartLineFormat, object>> selectExpression);

    }
}