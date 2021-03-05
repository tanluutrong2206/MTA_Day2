function validate() {
  const form = document.getElementById('form');

  console.log(form.email);
  // validate email
  const email = form.email.value;
  if (!email) {
    alert('Ban phai nhap email!');
    return false;
  } else {
      return true;
  }
}
