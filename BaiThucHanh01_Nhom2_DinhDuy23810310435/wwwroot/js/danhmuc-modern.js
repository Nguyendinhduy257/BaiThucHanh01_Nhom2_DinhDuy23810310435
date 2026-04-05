document.addEventListener("DOMContentLoaded", function () {
    lucide.createIcons();

    const form = document.querySelector('form');
    const inputs = document.querySelectorAll('.modern-input[required]');

    form.addEventListener('submit', function (e) {
        let hasError = false;
        inputs.forEach(input => {
            if (!input.value.trim()) {
                input.classList.add('shake');
                input.style.borderColor = '#ef4444';
                hasError = true;
                setTimeout(() => input.classList.remove('shake'), 500);
            }
        });

        if (hasError) {
            e.preventDefault();
            return;
        }

        // Hiệu ứng loading khi bấm nút
        const btn = document.querySelector('.btn-submit');
        btn.innerHTML = '<span class="loader"></span> Đang xử lý...';
        btn.style.opacity = '0.7';
        btn.style.pointerEvents = 'none';
    });

    // Reset màu khi gõ tiếp
    inputs.forEach(input => {
        input.addEventListener('input', () => {
            input.style.borderColor = 'transparent';
        });
    });
});