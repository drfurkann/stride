// Copyright (c) .NET Foundation and Contributors (https://dotnetfoundation.org/ & https://stride3d.net)
// Distributed under the MIT license. See the LICENSE.md file in the project root for more information.
using Stride.Core.Presentation.Quantum;
using Stride.Core.Presentation.Quantum.View;
using Stride.Core.Presentation.Quantum.ViewModels;

namespace Stride.Core.Assets.Editor.View.TemplateProviders
{
    public class ArrayItemTemplateProvider : TypeMatchTemplateProvider
    {
        public override string Name => "ArrayItem";

        public override bool MatchNode(NodeViewModel node)
        {
            return base.MatchNode(node) && node.Parent != null && node.Parent.Type.IsArray;
        }
    }
}
