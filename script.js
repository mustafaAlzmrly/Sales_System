// ßæÏ JS ÇáÎÇÕ Èß åäÇ

// ÅÖÇİÉ ãäÊÌ ÌÏíÏ
const addProductForm = document.getElementById('add-product-form');
addProductForm.addEventListener('submit', function (event) {
    event.preventDefault();
    // ÇÓÊÎÑÇÌ Şíã ÇáÍŞæá ãä ÇáäãæĞÌ
    const name = document.getElementById('name').value;
    const description = document.getElementById('description').value;
    const image = document.getElementById('image').value;
    const price = document.getElementById('price').value;

    // Şã ÈÅÑÓÇá ÇáŞíã Åáì ŞÇÚÏÉ ÇáÈíÇäÇÊ Ãæ Şã ÈãÚÇáÌÊåÇ ÈØÑíŞÉ ÃÎÑì
    // ...

    // ÅÚÇÏÉ ÊÚííä ÍŞæá ÇáäãæĞÌ
    addProductForm.reset();
});

// ÇáÈÍË Úä İÇÊæÑÉ
const searchInvoiceForm = document.getElementById('search-invoice-form');
searchInvoiceForm.addEventListener('submit', function (event) {
    event.preventDefault();
    // ÇÓÊÎÑÇÌ Şíã ÇáÍŞæá ãä ÇáäãæĞÌ
    const invoiceNumber = document.getElementById('invoice-number').value;
    const invoiceDate = document.getElementById('invoice-date').value;

    // Şã ÈÇáÈÍË Úä ÇáİÇÊæÑÉ İí ŞÇÚÏÉ ÇáÈíÇäÇÊ Ãæ Şã ÈãÚÇáÌÊåÇ ÈØÑíŞÉ ÃÎÑì
    // ...

    // ÅÚÇÏÉ ÊÚííä ÍŞæá ÇáäãæĞÌ
    searchInvoiceForm.reset();
});

// ÇáÚäÇÕÑ ÇáÃÎÑì
// ...