using System.Drawing;
using System.Drawing.Printing;
using DevExpress.XtraReports.UI;
// ...

namespace ConditionallyChangeAppearance {
    public partial class XtraReport1 : XtraReport {
        public XtraReport1() {
            InitializeComponent();
        }

        private void XtraReport1_BeforePrint(object sender, PrintEventArgs e) {
            // Create a new rule and add it to a report.
            FormattingRule rule = new FormattingRule();
            this.FormattingRuleSheet.Add(rule);

            // Specify the rule's properties.
            rule.DataSource = this.DataSource;
            rule.DataMember = this.DataMember;
            rule.Condition = "[UnitPrice] >= 30";
            rule.Formatting.BackColor = Color.WhiteSmoke;
            rule.Formatting.ForeColor = Color.IndianRed;
            rule.Formatting.Font = new Font("Arial", 10, FontStyle.Bold);

            // Apply this rule to the detail band.
            this.Detail.FormattingRules.Add(rule);
        }

    }
}
