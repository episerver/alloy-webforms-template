We keep all common web controls and user controls (except blocks) in this folder.
For server controls, make sure a prefix is included in web.config to allow for
easy use of the site's server controls in markup.

The name "Shared" was selected to reduce differences in folder structure between
WebForms and MVC projects.

In web.config:
<pages>
    <controls>
    <add tagPrefix="Alloy" namespace="AlloyTemplates.Views.Shared" assembly="AlloyTemplates" />
    </controls>
<pages>

Enables use of server controls like:
<Alloy:MyServerControl runat="server" />
