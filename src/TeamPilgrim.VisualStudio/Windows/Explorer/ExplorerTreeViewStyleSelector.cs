using System.Windows;
using System.Windows.Controls;
using JustAProgrammer.TeamPilgrim.VisualStudio.Model;
using JustAProgrammer.TeamPilgrim.VisualStudio.Model.BuildDefinitions;
using JustAProgrammer.TeamPilgrim.VisualStudio.Model.Core;
using JustAProgrammer.TeamPilgrim.VisualStudio.Model.VersionControl;
using JustAProgrammer.TeamPilgrim.VisualStudio.Model.WorkItemQuery;

namespace JustAProgrammer.TeamPilgrim.VisualStudio.Windows.Explorer
{
    public class ExplorerTreeViewStyleSelector : StyleSelector
    {
        public Style DefaultStyle { get; set; }

        public Style SourceControlStyle { get; set; }
        
        public Style BuildDefinitionStyle { get; set; }
        
        public Style ProjectCollectionStyle { get; set; }

        public Style ProjectStyle { get; set; }

        public Style WorkItemQueryContainerStyle { get; set; }
        
        public Style WorkItemQueryFolderStyle { get; set; }

        public Style WorkItemQueryDefinitionStyle { get; set; }

        public override Style SelectStyle(object item, DependencyObject container)
        {
            var projectCollectionModel = item as ProjectCollectionServiceModel;
            if (projectCollectionModel != null && ProjectCollectionStyle != null)
            {
                return ProjectCollectionStyle;
            }

            var projectModel = item as ProjectServiceModel;
            if (projectModel != null && ProjectStyle != null)
            {
                return ProjectStyle;
            }
            
            var workItemQueryContainerModel = item as WorkItemQueryServiceModel;
            if (workItemQueryContainerModel != null && WorkItemQueryContainerStyle != null)
            {
                return WorkItemQueryContainerStyle;
            }
            
            var sourceControlNode = item as SourceControlModel;
            if (sourceControlNode != null && SourceControlStyle != null)
            {
                return SourceControlStyle;
            }

            var queryDefinitionNode = item as WorkItemQueryDefinitionModel;
            if (queryDefinitionNode != null && WorkItemQueryDefinitionStyle != null)
            {
                return WorkItemQueryDefinitionStyle;
            }

            var queryFolderNode = item as WorkItemQueryFolderModel;
            if (queryFolderNode != null && WorkItemQueryFolderStyle != null)
            {
                return WorkItemQueryFolderStyle;
            }

            var buildDefinitionModel = item as BuildDefinitionModel;
            if (buildDefinitionModel != null && BuildDefinitionStyle != null)
            {
                return BuildDefinitionStyle;
            }

            return DefaultStyle ?? base.SelectStyle(item, container);
        }
    }
}