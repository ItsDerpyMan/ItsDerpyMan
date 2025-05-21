local map = vim.keymap.set

-- General mappings
map('n', '<leader>e', ':Ex<CR>', { desc = 'Open file explorer' })
map('n', '<leader>w', ':w<CR>', { desc = 'Save file' })

-- Conform.nvim
map('n', '<leader>f', function()
  require('conform').format({ async = true, lsp_fallback = true })
end, { desc = 'Format buffer' })

-- Fidget.nvim (optional)
map('n', '<leader>fp', function()
  require('fidget').toggle()
end, { desc = 'Toggle Fidget progress' })

-- LSP and rustaceanvim mappings
vim.api.nvim_create_autocmd('LspAttach', {
  callback = function(event)
    local opts = { buffer = event.buf }
    -- LSP mappings
    map('n', 'gd', vim.lsp.buf.definition, opts)
    map('n', 'K', vim.lsp.buf.hover, opts)
    map('n', '<leader>rn', vim.lsp.buf.rename, opts)
    map('n', '<leader>ca', vim.lsp.buf.code_action, opts)
    map('n', '[d', vim.diagnostic.goto_prev, opts)
    map('n', ']d', vim.diagnostic.goto_next, opts)
    map('n', '<leader>d', vim.diagnostic.open_float, opts)
    -- rustaceanvim mappings
    if vim.lsp.get_client_by_id(event.data.client_id).name == 'rust_analyzer' then
      map('n', '<leader>rr', ':RustLsp runnables<CR>', opts)
      map('n', '<leader>rd', ':RustLsp debuggables<CR>', opts)
      map('n', '<leader>re', ':RustLsp explainError<CR>', opts)
      map('n', '<leader>rf', ':RustLsp flyCheck<CR>', opts)
      map('n', '<leader>rt', ':RustLsp testables<CR>', opts)
      map('n', '<leader>rm', ':RustLsp expandMacro<CR>', opts)
    end
    -- Auto-clear highlights
    -- vim.api.nvim_create_autocmd('CursorMoved', {
    --   buffer = event.buf,
    --   callback = function()
    --     vim.lsp.buf.clear_references()
    --   end,
    -- })
  end,
})
