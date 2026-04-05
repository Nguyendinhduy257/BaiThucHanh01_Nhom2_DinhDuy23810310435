// wwwroot/js/info.js

// Khởi tạo bộ icon mượt mà từ thư viện Lucide
lucide.createIcons();

// Hàm click tim (Thêm hiệu ứng bong bóng nẩy siêu cấp)
function toggleLike(buttonElement) {
    buttonElement.classList.toggle('liked');

    // Thêm hiệu ứng nẩy khi click
    buttonElement.style.transform = 'scale(0.8)';
    setTimeout(() => {
        buttonElement.style.transform = 'scale(1.2)';
        setTimeout(() => {
            buttonElement.style.transform = 'scale(1)';
        }, 150);
    }, 100);
}
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