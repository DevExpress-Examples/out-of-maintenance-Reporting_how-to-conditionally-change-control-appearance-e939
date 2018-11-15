<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))
* [XtraReport1.cs](./CS/XtraReport1.cs) (VB: [XtraReport1.vb](./VB/XtraReport1.vb))
<!-- default file list end -->
# How to conditionally change control appearance


<p>This example demonstrates how to conditionally change control appearance at runtime. For this, it is necessary to create an instance of the FormattingRule class, specify its Condition and Formatting properties and add this objects to a report's sheet of formatting rules (XtraReport.FormattingRuleSheet) and to the collection of formatting rules of a control or a band, to which it should be applied (XRControl.FormattingRules).</p>

<br/>


