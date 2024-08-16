using System.Data;
using FluentMigrator.Builders.Create.Table;
using Nop.Core.Domain.Book;
using Nop.Core.Domain.Catalog;
using Nop.Core.Domain.Common;
using Nop.Data.Extensions;


namespace Nop.Data.Mapping.Builders.Book
{
    /// <summary>
    /// Represents a customer entity builder
    /// </summary>
    public partial class BooksBuilder : NopEntityBuilder<Books>
    {
        #region Methods

        /// <summary>
        /// Apply entity configuration
        /// </summary>
        /// <param name="table">Create table expression builder</param>
        public override void MapEntity(CreateTableExpressionBuilder table)
        {
            table
             .WithColumn(nameof(Books.Name)).AsString(400).NotNullable();
        }

        #endregion
    }
}