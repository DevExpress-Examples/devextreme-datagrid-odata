import './App.css';
import 'devextreme/dist/css/dx.material.blue.light.compact.css';
import DataGrid, { Column } from 'devextreme-react/data-grid';
import { DataSource, ODataStore } from 'devextreme/common/data';

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

function App(): JSX.Element {
  return (
    <div className="main">
      <DataGrid
        dataSource={dataSource}
        showBorders={true}
      >
        <Column dataField="Product_ID" />
        <Column
          dataField="Product_Name"
          width={250}
        />
        <Column
          dataField="Product_Cost"
          caption="Cost"
          dataType="number"
          format="currency"
        />
        <Column
          dataField="Product_Sale_Price"
          caption="Sale Price"
          dataType="number"
          format="currency"
        />
        <Column
          dataField="Product_Retail_Price"
          caption="Retail Price"
          dataType="number"
          format="currency"
        />
        <Column
          dataField="Product_Current_Inventory"
          caption="Inventory"
        />
      </DataGrid>
    </div>
  );
}

export default App;
