﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZKEACMS.Article.Models;

namespace ZKEACMS.Article
{
    public class ArticleDbContext : CMSDbContext
    {
        internal DbSet<ArticleEntity> Article { get; set; }
        internal DbSet<ArticleType> ArticleType { get; set; }
        internal DbSet<ArticleDetailWidget> ArticleDetailWidget { get; set; }
        internal DbSet<ArticleListWidget> ArticleListWidget { get; set; }
        internal DbSet<ArticleSummaryWidget> ArticleSummaryWidget { get; set; }
        internal DbSet<ArticleTopWidget> ArticleTopWidget { get; set; }
        internal DbSet<ArticleTypeWidget> ArticleTypeWidget { get; set; }
    }
}
