<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128619777/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3379)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<p>Note that the <b>DateTimeNumericRangeFormatElementEditable</b> class is obsolete in versions <b>20.2</b> and newer.</p>

<!-- default file list -->
*Files to look at*:

* [EditElement.cs](./CS/RangedMaskSample/EditElement.cs) (VB: [EditElement.vb](./VB/RangedMaskSample/EditElement.vb))
* [EditElementCollection.cs](./CS/RangedMaskSample/EditElementCollection.cs) (VB: [EditElementCollection.vb](./VB/RangedMaskSample/EditElementCollection.vb))
* [Form1.cs](./CS/RangedMaskSample/Form1.cs) (VB: [Form1.vb](./VB/RangedMaskSample/Form1.vb))
* [MaskButtonEdit.cs](./CS/RangedMaskSample/MaskButtonEdit.cs) (VB: [MaskButtonEditMaskProperties.vb](./VB/RangedMaskSample/MaskButtonEditMaskProperties.vb))
* [MaskButtonEditMaskFormatElement.cs](./CS/RangedMaskSample/MaskButtonEditMaskFormatElement.cs) (VB: [MaskButtonEditMaskFormatElement.vb](./VB/RangedMaskSample/MaskButtonEditMaskFormatElement.vb))
* [MaskButtonEditMaskFormatInfo.cs](./CS/RangedMaskSample/MaskButtonEditMaskFormatInfo.cs) (VB: [MaskButtonEditMaskFormatInfo.vb](./VB/RangedMaskSample/MaskButtonEditMaskFormatInfo.vb))
* [MaskButtonEditMaskManager.cs](./CS/RangedMaskSample/MaskButtonEditMaskManager.cs) (VB: [MaskButtonEditMaskManager.vb](./VB/RangedMaskSample/MaskButtonEditMaskManager.vb))
* [MaskButtonEditMaskProperties.cs](./CS/RangedMaskSample/MaskButtonEditMaskProperties.cs) (VB: [MaskButtonEditMaskProperties.vb](./VB/RangedMaskSample/MaskButtonEditMaskProperties.vb))
* [MaskElement.cs](./CS/RangedMaskSample/MaskElement.cs) (VB: [MaskElementCollection.vb](./VB/RangedMaskSample/MaskElementCollection.vb))
* [MaskElementCollection.cs](./CS/RangedMaskSample/MaskElementCollection.cs) (VB: [MaskElementCollection.vb](./VB/RangedMaskSample/MaskElementCollection.vb))
* [MaskElementsRepository.cs](./CS/RangedMaskSample/MaskElementsRepository.cs) (VB: [MaskElementsRepository.vb](./VB/RangedMaskSample/MaskElementsRepository.vb))
* [Program.cs](./CS/RangedMaskSample/Program.cs) (VB: [Program.vb](./VB/RangedMaskSample/Program.vb))
* [RepositoryItemMaskButtonEdit.cs](./CS/RangedMaskSample/RepositoryItemMaskButtonEdit.cs) (VB: [RepositoryItemMaskButtonEdit.vb](./VB/RangedMaskSample/RepositoryItemMaskButtonEdit.vb))
<!-- default file list end -->
# How to create a masked editor with specified ranges for every mask part


<p>If you need an editor with spin edit capabilities to change values in a cycle using a custom range for every single part of the specified mask, this example explains how to obtain it. This editor corresponds to a descendant of the ButtonEdit control and its behavior is based on storing custom mask elements values in external storage (MaskElementsRepository). The ability to cycle through mask parts is achieved by assigning a mask of the DateTime type and specifying the low and high cycle bounds in the corresponding MaskElement, which can be obtained through the editor's Properties.MaskElements property. This property refers to the global collection of MaskElements, which is used for all editors of this type.</p><br />
<p><strong>Important note</strong>: this approach works *<strong>ONLY</strong>* for stand-alone editors.</p><p>See also:<br />
<a href="https://www.devexpress.com/Support/Center/p/E2443">E2443: How to create an IP address editor with the capability of cycling through every part of an IP address</a><br />
<a href="https://www.devexpress.com/Support/Center/p/K18332">K18332: How to create a custom editor that will allow editing TimeSpan values </a></p>

<br/>


