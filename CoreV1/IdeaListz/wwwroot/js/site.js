$(document).ready(function() {
  $('#add-idea-button').on('click', addIdea);
});

function addIdea() {
  $('#add-idea-error').hide();
  var ideaTitle = $('#add-idea-title').val();
  var ideaDescription = $('#add-idea-description').val();
  
  $.post('/Idea/AddIdea', { title: ideaTitle, description: ideaDescription }, function() {
    window.location = '/Idea';
  })
  .fail(function(data) {
    if (data && data.responseJSON) {
      var firstError = data.responseJSON[Object.keys(data.responseJSON)[0]];
      $('#add-idea-error').text(firstError);
      $('#add-idea-error').show();
    }
  });
}
