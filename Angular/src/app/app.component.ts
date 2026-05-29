import { Component } from '@angular/core';
import { DataSource, ODataStore } from 'devextreme-angular/common/data';
import { DxDataGridModule } from 'devextreme-angular/ui/data-grid';

@Component({
  imports: [DxDataGridModule],
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss'],
})
export class AppComponent {
  dataSource = new DataSource({
    store: new ODataStore({
      version: 4,
      url: 'http://localhost:5005/odata/Products',
      key: 'Product_ID',
    }),
    select: [
      'Product_ID',
      'Product_Name',
      'Product_Production_Start',
      'Product_Cost',
      'Product_Sale_Price',
      'Product_Retail_Price',
      'Product_Current_Inventory',
    ],
    filter: ['Product_Current_Inventory', '>', 0],
  });
}
