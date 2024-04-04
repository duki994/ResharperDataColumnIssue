# A demo for Resharper 2023.3.4 symbol 'not resolved' bug


Just open DataColumns.aspx.vb and you will see that the `DataColumn` class in System.Data namespace is not resolved by Resharper,
but works ok with VB.NET compiler and MSBuild.