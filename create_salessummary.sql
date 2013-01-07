select  a.prod_id "Product", b.desc "Description", 
sum(a.qty) "Quant.", sum(a.weight) "Weight",(sum(a.weight)/sum(a.qty)) "Avg-Weight",sum(a.amount) "Amount"
from invoice_items a join products b on a.prod_id = b.prod_id
group by a.prod_id