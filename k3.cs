using System.Security.Policy;

< FileAlignment > 512 </ FileAlignment >
    < AutoGenerateBindingRedirects > true </ AutoGenerateBindingRedirects >
    < Deterministic > true </ Deterministic >
    < PublishUrl > publish\</ PublishUrl >
    < Install > true </ Install >
    < InstallFrom > Disk </ InstallFrom >
    < UpdateEnabled > false </ UpdateEnabled >
    < UpdateMode > Foreground </ UpdateMode >
    < UpdateInterval > 7 </ UpdateInterval >
    < UpdateIntervalUnits > Days </ UpdateIntervalUnits >
    < UpdatePeriodically > false </ UpdatePeriodically >
    < UpdateRequired > false </ UpdateRequired >
    < MapFileExtensions > true </ MapFileExtensions >
    < ApplicationRevision > 0 </ ApplicationRevision >
    < ApplicationVersion > 1.0.0.% 2a </ ApplicationVersion >
    < IsWebBootstrapper > false </ IsWebBootstrapper >
    < UseApplicationTrust > false </ UseApplicationTrust >
    < BootstrapperEnabled > true </ BootstrapperEnabled >
  </ PropertyGroup >
  < PropertyGroup Condition = " '$(Configuration)|$(Platform)' == 'Debug|AnyCPU' " >
    < PlatformTarget > AnyCPU </ PlatformTarget >
@@ -76,5 + 91,26 @@
  < ItemGroup >
    < None Include = "App.config" />
  </ ItemGroup >
  < ItemGroup >
    < Content Include = "db_academica.mdf" >
      < CopyToOutputDirectory > Always </ CopyToOutputDirectory >
    </ Content >
    < Content Include = "db_academica_log.ldf" >
      < CopyToOutputDirectory > Always </ CopyToOutputDirectory >
      < DependentUpon > db_academica.mdf </ DependentUpon >
    </ Content >
  </ ItemGroup >
  < ItemGroup >
    < BootstrapperPackage Include = ".NETFramework,Version=v4.8" >
      < Visible > False </ Visible >
      < ProductName > Microsoft.NET Framework 4.8 %28x86 y x64%29</ProductName>
      <Install>true</Install>
    </BootstrapperPackage>
    <BootstrapperPackage Include="Microsoft.Net.Framework.3.5.SP1">
      <Visible>False</Visible>
      <ProductName>.NET Framework 3.5 SP1</ProductName>
      <Install>false</Install>
    </BootstrapperPackage>
  </ItemGroup>
  <Import Project="$(MSBuildToolsPath)\Microsoft.CSharp.targets" />
</Project>
‎academica/academica/academica.csproj.user
+13
Original file line number	Diff line number	Diff line change
@@ -0,0 +1,13 @@
<?xml version="1.0" encoding="utf-8"?>
<Project ToolsVersion="Current" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <PropertyGroup>
    <PublishUrlHistory />
    <InstallUrlHistory />
    <SupportUrlHistory />
    <UpdateUrlHistory />
    <BootstrapperUrlHistory />
    <ErrorReportUrlHistory />
    <FallbackCulture>es-ES</FallbackCulture>
    <VerifyUploadedFiles>false</VerifyUploadedFiles>
  </PropertyGroup>
</Project>