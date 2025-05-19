
$('a[name="btn-delete-pokemon"]').click(function () {
	var pokemonId = $(this).data('pokemon-id')
	deletePokemon(pokemonId)
	
})


function deletePokemon(id) {
	Swal.fire({
		title: "Deseja mesmo excluir este pokémon?",
		icon: "question",
		showCancelButton: true,
		confirmButtonText: "Remover",
	}).then((result) => {
		if (result.isConfirmed) {
			$.post(`/Pokemon/Delete`, { id }).done(function (response) {
				if (response.success) {
					toastSuccess('Pokémon excluído com sucesso!')
					location.reload()
				} else {
					toastError(response.errorMessage)
				}
			}).fail(function (xhr, status, error) {
				toastError('Não foi possível excluir o Pokémon.')
			});
		} 
	});
}