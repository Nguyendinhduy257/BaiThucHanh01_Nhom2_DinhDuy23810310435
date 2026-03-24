// wwwroot/js/info.js

// Kích hoạt Lucide Icons
lucide.createIcons();

// Hàm lọc sản phẩm theo Tab
function filterTab(category, tabElement) {
    // Cập nhật CSS cho Tab đang chọn
    document.querySelectorAll('.tab').forEach(t => t.classList.remove('active'));
    tabElement.classList.add('active');

    // Ẩn/hiện thẻ sản phẩm dựa vào data attributes
    const cards = document.querySelectorAll('.product-card');
    cards.forEach(card => {
        if (category === 'new' && card.getAttribute('data-new') === 'true') {
            card.style.display = 'block';
        } else if (category === 'sale' && card.getAttribute('data-sale') === 'true') {
            card.style.display = 'block';
        } else if (category === 'featured' && card.getAttribute('data-featured') === 'true') {
            card.style.display = 'block';
        } else {
            card.style.display = 'none';
        }
    });
}

// Tự động click vào Tab đầu tiên (mặc định) khi vừa tải trang
//window.onload = function () {
//    const firstTab = document.querySelector('.tab');
//    if (firstTab) {
//        firstTab.click();
//    }
//};