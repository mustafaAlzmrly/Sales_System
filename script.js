// ��� JS ����� �� ���

// ����� ���� ����
const addProductForm = document.getElementById('add-product-form');
addProductForm.addEventListener('submit', function (event) {
    event.preventDefault();
    // ������� ��� ������ �� �������
    const name = document.getElementById('name').value;
    const description = document.getElementById('description').value;
    const image = document.getElementById('image').value;
    const price = document.getElementById('price').value;

    // �� ������ ����� ��� ����� �������� �� �� ��������� ������ ����
    // ...

    // ����� ����� ���� �������
    addProductForm.reset();
});

// ����� �� ������
const searchInvoiceForm = document.getElementById('search-invoice-form');
searchInvoiceForm.addEventListener('submit', function (event) {
    event.preventDefault();
    // ������� ��� ������ �� �������
    const invoiceNumber = document.getElementById('invoice-number').value;
    const invoiceDate = document.getElementById('invoice-date').value;

    // �� ������ �� �������� �� ����� �������� �� �� ��������� ������ ����
    // ...

    // ����� ����� ���� �������
    searchInvoiceForm.reset();
});

// ������� ������
// ...