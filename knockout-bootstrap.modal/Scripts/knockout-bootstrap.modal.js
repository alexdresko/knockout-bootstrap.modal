ko.bindingHandlers["bootstrapModal"] = {
	init: function(element) {
		ko.utils.toggleDomNodeCssClass(element, "modal hide", true);
		$(element).modal({
			"backdrop": "static",
			keyboard: false,
			show: false
		});
	},
	update: function(element, valueAccessor) {
		var props = valueAccessor();
		$(element).modal(props.visible() ? 'show' : 'hide');
	}
};
//@ sourceMappingURL=knockout-bootstrap.modal.js.map