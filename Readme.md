# How to create a masked editor with specified ranges for every mask part


<p>If you need an editor with spin edit capabilities to change values in a cycle using a custom range for every single part of the specified mask, this example explains how to obtain it. This editor corresponds to a descendant of the ButtonEdit control and its behavior is based on storing custom mask elements values in external storage (MaskElementsRepository). The ability to cycle through mask parts is achieved by assigning a mask of the DateTime type and specifying the low and high cycle bounds in the corresponding MaskElement, which can be obtained through the editor's Properties.MaskElements property. This property refers to the global collection of MaskElements, which is used for all editors of this type.</p><br />
<p><strong>Important note</strong>: this approach works *<strong>ONLY</strong>* for stand-alone editors.</p><p>See also:<br />
<a href="https://www.devexpress.com/Support/Center/p/E2443">E2443: How to create an IP address editor with the capability of cycling through every part of an IP address</a><br />
<a href="https://www.devexpress.com/Support/Center/p/K18332">K18332: How to create a custom editor that will allow editing TimeSpan values </a></p>

<br/>


