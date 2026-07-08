import { formatCurrency } from '../../utils/formatters'
import { Card } from './Card'

// Cartao de indicador financeiro com cor semantica para renda, despesa ou saldo.
interface StatCardProps {
  label: string
  value: number
  tone?: 'income' | 'expense' | 'balance'
}

export function StatCard({ label, value, tone = 'balance' }: StatCardProps) {
  return (
    <Card className={`stat-card stat-card--${tone}`}>
      <span>{label}</span>
      <strong>{formatCurrency(value)}</strong>
    </Card>
  )
}
