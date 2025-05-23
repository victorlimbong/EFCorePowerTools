﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Scaffolding;
using RevEng.Core.Abstractions;
using RevEng.Core.Abstractions.Metadata;

namespace RevEng.Core.Routines.Procedures
{
    public class NotImplementedProcedureScaffolder : IProcedureScaffolder
    {
        public SavedModelFiles Save(ScaffoldedModel scaffoldedModel, string outputDir, string nameSpaceValue, bool useAsyncCalls, bool useInternalAccessModifier)
        {
            throw new NotSupportedException();
        }

        public ScaffoldedModel ScaffoldModel(RoutineModel model, ModuleScaffolderOptions scaffolderOptions, List<string> schemas, ref List<string> errors)
        {
            throw new NotSupportedException();
        }
    }
}