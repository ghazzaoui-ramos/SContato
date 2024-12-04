function filterArtists() {
    const input = document.getElementById('searchInput').value.toUpperCase();
    const ul = document.getElementById('artistList');
    const li = ul.getElementsByTagName('li');
  
    for (let i = 0; i < li.length; i++) {
      const a = li[i].getElementsByTagName('a')[0];
      if (a.innerHTML.toUpperCase().indexOf(input) > -1) {
        li[i].style.display = "";
      } else {
        li[i].style.display = "none";
      }
    }
  }
  
  function openModal(src) {
    const modal = document.getElementById("imageModal");
    const modalImage = document.getElementById("modalImage");
    
    modal.style.display = "block";
    modalImage.src = src;
}

function closeModal() {
    const modal = document.getElementById("imageModal");
    modal.style.display = "none";
}


function toggleInstaLinks() {
  const extraLinks = document.getElementById("extraInstaLinks");
  if (extraLinks.style.display === "none") {
      extraLinks.style.display = "block";
  } else {
      extraLinks.style.display = "none";
  }
}

function toggleYoutubeLinks() {
  const extraLinks = document.getElementById("extraYoutubeLinks");
  extraLinks.style.display = extraLinks.style.display === "none" ? "block" : "none";
}

function togglespotifyLinks() {
  const extraLinks = document.getElementById("extraspotifyLinks");
  extraLinks.style.display = extraLinks.style.display === "none" ? "block" : "none";
}

function toggleRedeSocialLinks() {
  const extraLinks = document.getElementById("extraRedeSocialLinks");
  extraLinks.style.display = extraLinks.style.display === "none" ? "block" : "none";
}


// Função para abrir o modal de Social Media
function openSocialMediaModal() {
  document.getElementById("socialMediaModal").style.display = "flex";
}

// Função para fechar o modal de Social Media
function closeSocialMediaModal() {
  document.getElementById("socialMediaModal").style.display = "none";
}

// Fechar o modal clicando fora do conteúdo
window.onclick = function(event) {
  var modal = document.getElementById("socialMediaModal");
  if (event.target == modal) {
    closeSocialMediaModal();
  }
}


  