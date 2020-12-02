
# How to create a masked editor with specified ranges for every mask part

<p> We improved our mask function in v.20.2.1. Please review our BC articles for more information:<br />
<a href="https://supportcenter.devexpress.com/ticket/details/t935649/timespanedit-now-uses-the-timespan-input-mask">TimeSpanEdit now uses the TimeSpan input mask</a><br />
<a href="https://supportcenter.devexpress.com/ticket/details/t936822/timespan-mask-behavior-is-changed-in-specific-scenarios">TimeSpan mask behavior is changed in specific scenarios</a><br />
</p>

<p> We suggest you use a custom mask to achieve a similar goal in version 20.2+. For example, you can use expressions like hh3 to specify the maximum number of digits. In this case, an editor will change values in a cycle taking this maximum value into account</p>


