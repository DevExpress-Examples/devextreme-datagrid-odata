<script setup lang="ts">
import 'devextreme/dist/css/dx.material.blue.light.compact.css';
import DxDataGrid from 'devextreme-vue/data-grid';
import { DataSource, ODataStore } from 'devextreme-vue/common/data';

const dataSource = new DataSource({
  store: new ODataStore({
    version: 4,
    url: 'http://localhost:5005/odata/Products',
    key: 'Product_ID',
  }),
  select: [
    'Product_ID',
    'Product_Name',
    'Product_Cost',
    'Product_Sale_Price',
    'Product_Retail_Price',
    'Product_Current_Inventory',
  ],
  filter: ['Product_Current_Inventory', '>', 0],
});
</script>
<template>
  <div>
    <DxDataGrid
      :data-source="dataSource"
      :show-borders="true"
    >
      <DxColumn data-field="Product_ID"/>
      <DxColumn
        :width="250"
        data-field="Product_Name"
      />
      <DxColumn
        data-field="Product_Cost"
        caption="Cost"
        data-type="number"
        format="currency"
      />
      <DxColumn
        data-field="Product_Sale_Price"
        caption="Sale Price"
        data-type="number"
        format="currency"
      />
      <DxColumn
        data-field="Product_Retail_Price"
        caption="Retail Price"
        data-type="number"
        format="currency"
      />
      <DxColumn
        data-field="Product_Current_Inventory"
        caption="Inventory"
      />
    </DxDataGrid>
  </div>
</template>
