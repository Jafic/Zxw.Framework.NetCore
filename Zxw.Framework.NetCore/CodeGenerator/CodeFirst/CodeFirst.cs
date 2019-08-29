﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Options;
using Zxw.Framework.NetCore.IoC;
using Zxw.Framework.NetCore.Models;
using Zxw.Framework.NetCore.Options;

namespace Zxw.Framework.NetCore.CodeGenerator.CodeFirst
{
    internal sealed class CodeFirst:ICodeFirst
    {
        private CodeGenerator Instance { get; set; }
        public CodeFirst(IOptions<CodeGenerateOption> option)
        {
            if (option == null) throw new ArgumentNullException(nameof(option));
            Instance = new CodeGenerator(option.Value);
        }

        public void GenerateAll(bool ifExsitedCovered = false)
        {
            Instance.Generate(ifExsitedCovered);
        }

        public ICodeFirst GenerateSingle<T, TKey>(bool ifExsitedCovered = false) where T : BaseModel<TKey>
        {
            Instance.GenerateSingle<T, TKey>(ifExsitedCovered);
            return this;
        }

        public ICodeFirst GenerateIRepository<T, TKey>(bool ifExsitedCovered = false) where T : BaseModel<TKey>
        {
            Instance.GenerateIRepository<T, TKey>(ifExsitedCovered);
            return this;
        }

        public ICodeFirst GenerateRepository<T, TKey>(bool ifExsitedCovered = false) where T : BaseModel<TKey>
        {
            Instance.GenerateRepository<T, TKey>(ifExsitedCovered);
            return this;
        }

        public ICodeFirst GenerateIService<T, TKey>(bool ifExsitedCovered = false) where T : BaseModel<TKey>
        {
            Instance.GenerateIService<T, TKey>(ifExsitedCovered);
            return this;
        }

        public ICodeFirst GenerateService<T, TKey>(bool ifExsitedCovered = false) where T : BaseModel<TKey>
        {
            Instance.GenerateService<T, TKey>(ifExsitedCovered);
            return this;
        }

        public ICodeFirst GenerateController<T, TKey>(bool ifExsitedCovered = false) where T : BaseModel<TKey>
        {
            Instance.GenerateController<T, TKey>(ifExsitedCovered);
            return this;
        }

        public ICodeFirst GenerateApiController<T, TKey>(bool ifExsitedCovered = false) where T : BaseModel<TKey>
        {
            Instance.GenerateApiController<T, TKey>(ifExsitedCovered);
            return this;
        }
    }
}
