Several of the default Orchard shapes and Views have been modified within this theme to change the structure and class assignment for use with Bootstrap.

There are also shapes being automatically injected into layout.cshtml. If there are shapes you would not like to appear, such as the user dropdown or search box, simply comment out the lines for those shapes under the Inserting some ad hoc shapes section.

To use the Advanced Menu module with this theme, install and enable it. The Views and Shapes for the Advanced Menu module will be overridden by ones contained in this theme. Setting the colors on the widget will have no effect.

To add a divider to the dropdown menu, add an item using the + Add item button. Set the displayed text to "&nbsp;" without the quotes. Set the position where you'd like the divider to appear in the menu. Set the additional CSS classes to "divider" without the quotes.

The menu has been configured to go to only 1 level deep of submenus. If you need more than 1 level of submenus, edit the MenuStyle.cshtml file in Views.