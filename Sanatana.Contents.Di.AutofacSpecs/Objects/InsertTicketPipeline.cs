﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using Sanatana.Contents.Database;
using Sanatana.Contents.Files.Queries;
using Sanatana.Contents.Html.Media;
using Sanatana.Contents.Objects.Entities;
using Sanatana.Contents.Pipelines;
using Sanatana.Contents.Pipelines.Contents;
using Sanatana.Contents.Search;
using Sanatana.Contents.Selectors.Permissions;
using Sanatana.Contents.Utilities;

namespace Sanatana.Contents.Di.AutofacSpecs.Objects
{
    public class InsertTicketPipeline 
        : InsertContentPipeline<ObjectId, Category<ObjectId>, Ticket<ObjectId>>
    {

        public InsertTicketPipeline(IPipelineExceptionHandler exceptionHandler, IContentQueries<ObjectId, Ticket<ObjectId>> contentQueries
            , IPermissionSelector<ObjectId, Category<ObjectId>> permissionSelector, ISearchQueries<ObjectId> searchQueries
            , IImageFileQueries imageFileQueries, IHtmlMediaExtractor htmlMediaExtractor, IUrlEncoder urlEncoder)
            : base(exceptionHandler, contentQueries, permissionSelector
                  , searchQueries, imageFileQueries, htmlMediaExtractor, urlEncoder)
        {

        }

        public override Task<ContentEditResult> Execute(ContentEditParams<ObjectId, Ticket<ObjectId>> inputModel, ContentEditResult outputModel)
        {
            return base.Execute(inputModel, outputModel);
        }
    }
}