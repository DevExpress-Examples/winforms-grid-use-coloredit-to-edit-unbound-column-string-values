<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128624894/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3080)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# WinForms Data Grid - Use a Color Editor to edit colors that are stored as strings

The WinForms ColorEdit is designed to work with values of the `Color` type. In this example, the data source stores colors as strings in the "ColorString" field. Follow the steps below to use the Color Editor to display and edit "ColorString" field values:

1. Create an unbound column:

  ```csharp
  GridColumn unboundColumn = gridView1.Columns.AddField("Color");
  unboundColumn.VisibleIndex = gridView1.Columns.Count;
  unboundColumn.UnboundType = DevExpress.Data.UnboundColumnType.Object;
  ```
2. Create a [RepositoryItemColorEdit](https://docs.devexpress.com/WindowsForms/DevExpress.XtraEditors.Repository.RepositoryItemColorEdit) cell editor and assign it to the unbound column:
    
  ```csharp
  RepositoryItemColorEdit ce = new RepositoryItemColorEdit();
  ce.ShowCustomColors = false;
  unboundColumn.ColumnEdit = ce;
  ```
3. Handle the GridView's [CustomUnboundColumnData](https://docs.devexpress.com/WindowsForms/DevExpress.XtraGrid.Views.Base.ColumnView.CustomUnboundColumnData) event to supply data for the unbound column (to convert string values to `Color`):
  
  ```csharp
  private void gridView1_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e) {
      GridView view = sender as GridView;
      DataView dv = view.DataSource as DataView;
      if (e.IsGetData)
          e.Value = GetColorFromString(dv[e.ListSourceRowIndex]["ColorString"].ToString());
      else
          dv[e.ListSourceRowIndex]["ColorString"] = ((Color)e.Value).Name;
  }

  Color GetColorFromString(string colorString) {
      Color color = Color.Empty;
      ColorConverter converter = new ColorConverter();
      try { 
          color = (Color)converter.ConvertFromString(colorString); 
      }
      catch { }
      return color;
  }
  ```


## Files to Review

* [Form1.cs](./CS/ColorEditExample/Form1.cs) (VB: [Form1.vb](./VB/ColorEditExample/Form1.vb))


## Documentation

* [Unbound Columns](https://docs.devexpress.com/WindowsForms/1477/controls-and-libraries/data-grid/unbound-columns)
* [Tutorial: Unbound Columns](https://docs.devexpress.com/WindowsForms/114678/controls-and-libraries/data-grid/getting-started/walkthroughs/data-binding-and-working-with-columns/tutorial-unbound-columns)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-grid-use-coloredit-to-edit-unbound-column-string-values&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-grid-use-coloredit-to-edit-unbound-column-string-values&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
