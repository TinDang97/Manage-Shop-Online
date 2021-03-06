// <copyright file="PexAssemblyInfo.cs">Copyright ©  2017</copyright>
using Microsoft.Pex.Framework.Coverage;
using Microsoft.Pex.Framework.Creatable;
using Microsoft.Pex.Framework.Instrumentation;
using Microsoft.Pex.Framework.Settings;
using Microsoft.Pex.Framework.Validation;

// Microsoft.Pex.Framework.Settings
[assembly: PexAssemblySettings(TestFramework = "VisualStudioUnitTest")]

// Microsoft.Pex.Framework.Instrumentation
[assembly: PexAssemblyUnderTest("StoreManager")]
[assembly: PexInstrumentAssembly("System.Drawing")]
[assembly: PexInstrumentAssembly("DevExpress.XtraCharts.v17.2")]
[assembly: PexInstrumentAssembly("DevExpress.XtraBars.v17.2")]
[assembly: PexInstrumentAssembly("System.Data.DataSetExtensions")]
[assembly: PexInstrumentAssembly("DevExpress.BonusSkins.v17.2")]
[assembly: PexInstrumentAssembly("DevExpress.Data.v17.2")]
[assembly: PexInstrumentAssembly("System.Core")]
[assembly: PexInstrumentAssembly("DevExpress.XtraEditors.v17.2")]
[assembly: PexInstrumentAssembly("ClassLibrary3")]
[assembly: PexInstrumentAssembly("System.Windows.Forms")]
[assembly: PexInstrumentAssembly("DevExpress.XtraGrid.v17.2")]
[assembly: PexInstrumentAssembly("DevExpress.XtraCharts.v17.2.UI")]
[assembly: PexInstrumentAssembly("System.Data")]
[assembly: PexInstrumentAssembly("DevExpress.Utils.v17.2")]

// Microsoft.Pex.Framework.Creatable
[assembly: PexCreatableFactoryForDelegates]

// Microsoft.Pex.Framework.Validation
[assembly: PexAllowedContractRequiresFailureAtTypeUnderTestSurface]
[assembly: PexAllowedXmlDocumentedException]

// Microsoft.Pex.Framework.Coverage
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "System.Drawing")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "DevExpress.XtraCharts.v17.2")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "DevExpress.XtraBars.v17.2")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "System.Data.DataSetExtensions")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "DevExpress.BonusSkins.v17.2")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "DevExpress.Data.v17.2")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "System.Core")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "DevExpress.XtraEditors.v17.2")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "ClassLibrary3")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "System.Windows.Forms")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "DevExpress.XtraGrid.v17.2")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "DevExpress.XtraCharts.v17.2.UI")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "System.Data")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "DevExpress.Utils.v17.2")]

