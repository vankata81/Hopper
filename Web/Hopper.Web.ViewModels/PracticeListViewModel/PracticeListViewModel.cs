namespace Hopper.Web.ViewModels.PracticeListViewModel
{
    using System;
    using System.Collections.Generic;

    using AutoMapper;
    using Hopper.Data.Models;

    public class PracticeListViewModel
    {
        public IEnumerable<PracticeinListViewModel> Practices { get; set; }

        public int PageNumber { get; set; }

        public int PracticesCount { get; set; }

        public int ItemsPerPage { get; set; }

        public bool HasPrevPage => this.PageNumber > 1;

        public bool HasNextPage => this.PageNumber < this.PagesCount;

        public int PreviousPageNumber => this.PageNumber - 1;

        public int NextPageNumber => this.PageNumber + 1;

        public int PagesCount => (int)Math.Ceiling((double)this.PracticesCount / this.ItemsPerPage);
    }
}
