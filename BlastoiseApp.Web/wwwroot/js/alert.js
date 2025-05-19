function successAlert(title, text) {
	Swal.fire({
		title: title,
		text: text,
		icon: "success",
		confirmButtonText: "Ok",
	})
}

function errorAlert(title, text) {
	Swal.fire({
		title: title,
		text: text,
		icon: "error",
		confirmButtonText: "Ok",
	})
}

var toastMixin = Swal.mixin({
	toast: true,
	animation: true,
	position: 'top-right',
	showConfirmButton: false,
	timer: 3000,
	timerProgressBar: true,
	didOpen: (toast) => {
		toast.addEventListener('mouseenter', Swal.stopTimer)
		toast.addEventListener('mouseleave', Swal.resumeTimer)
	}
});


function toastSuccess(title, text) {
	toastMixin.fire({
		icon: 'success',
		title: title,
		text: text
	})
}
function toastError(title, text) {
	toastMixin.fire({
		icon: 'error',
		title: title,
		text: text
	})
}